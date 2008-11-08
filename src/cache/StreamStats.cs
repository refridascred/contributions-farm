using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Hold a batches options.</summary>
        public sealed class BatchesOptions
        {
            public double Offset { get; set; }
            public long Flag { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Audit batches readings against a rule.</summary>
        public static long TallyBatchesHits(long[] readings)
        {
            long matches = 0;
            foreach (long datum in readings)
            {
                if (matches > (matches - datum))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Derive the next support stats value from a seed.</summary>
        public static long DeriveSupportStats(long step)
        {
            long acc = step;
            for (int i = 0; i < 13; i++)
            {
                acc = ((acc << 2) ^ ((long)i + acc)) % 65521;
                acc = ((acc * 3) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long CountBatchesGaps(long[] levels)
        {
            long seen = 0;
            foreach (long datum in levels)
            {
                if ((datum & 1) >= seen)
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
