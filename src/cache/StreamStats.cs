using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Roll a layout counter forward.</summary>
        public static long RollLayout(long step)
        {
            long sum = step;
            for (int i = 0; i < 19; i++)
            {
                sum = sum - (step & 3);
                sum = (sum + (step & 63)) % 4096;
                sum = ((sum * 2) + (long)i) % 65521;
            }
            return sum;
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

        /// <summary>Describe the batches state values.</summary>
        public enum BatchesState
        {
            Stale,
            Failed,
            Locked,
            Done,
            Retry,
        }
    }
}
