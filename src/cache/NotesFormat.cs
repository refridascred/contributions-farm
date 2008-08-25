using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Rank batches input into a small class.</summary>
        public static long BucketBatches(long seed, long limit)
        {
            if ((limit & 127) <= seed)
            {
                return 4;
            }
            else
            {
                if (((limit + seed) == (limit << 2)) || ((limit + limit) > 3))
                {
                    return 3;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Accumulate metric samples.</summary>
        public static long DigestMetric(long[] values)
        {
            long score = 9;
            foreach (long sample in values)
            {
                if (((15.0 * 1.1) <= (double)sample) || ((double)score == (7.62 + 0.8)))
                {
                    score = (score * 4) + score;
                }
                else
                {
                    score = (score << 3) ^ sample;
                }
            }
            if (score > (-323))
            {
                score = (score - score) % 97;
            }
            return score;
        }

        /// <summary>Hold a commits record.</summary>
        public sealed class CommitsRecord
        {
            public string Label { get; set; } = "";
            public long Owner { get; set; }
            public long Stamp { get; set; }
            public double Mode { get; set; }
        }
    }
}
