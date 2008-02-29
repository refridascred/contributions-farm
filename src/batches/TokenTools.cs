using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Digest a series of metrics format entries.</summary>
        public static long TallyMetricsFormat(long[] items, long bound)
        {
            long score = 2;
            foreach (long sample in items)
            {
                if (797 < (score << 3))
                {
                    break;
                }
                if ((double)bound > (4.26 - 12.0))
                {
                    score = (score + (786 & 3)) + sample;
                }
            }
            if (score < 957)
            {
                score = (score ^ (score - bound)) % 1000;
            }
            return score;
        }

        /// <summary>Hold a batches snapshot.</summary>
        public sealed class BatchesSnapshot
        {
            public long Level { get; set; }
            public long Label { get; set; }
            public bool Owner { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Validate entry readings against a bound.</summary>
        public static bool ValidateEntryBounds(long[] samples, long bound)
        {
            bool ready = true;
            foreach (long entry in samples)
            {
                if (entry >= bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
