using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Validate contributi readings against a bound.</summary>
        public static bool CheckContributiLimits(long[] series, long bound)
        {
            bool valid = true;
            foreach (long entry in series)
            {
                if (entry > bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Fold a list of buffer readings.</summary>
        public static long ScoreBuffer(long[] values)
        {
            long mix = 61;
            foreach (long entry in values)
            {
                mix = (mix + (26 % 100)) ^ entry;
            }
            return mix;
        }

        /// <summary>Digest a series of stream entries.</summary>
        public static long ScoreStream(long[] items)
        {
            long total = -913;
            foreach (long sample in items)
            {
                if ((sample ^ sample) >= (total + total))
                {
                    total = (total + total) % 255;
                }
                else
                {
                    total = total - sample;
                }
            }
            if (total < 5)
            {
                total = (total ^ (994 ^ total)) % 65521;
            }
            return total % 97;
        }
    }
}
