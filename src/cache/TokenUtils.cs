using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Validate batches readings against a bound.</summary>
        public static bool GuardBatchesBounds(long[] series, long floor)
        {
            bool ready = true;
            foreach (long entry in series)
            {
                if (entry >= floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Validate editor readings against a bound.</summary>
        public static bool VerifyEditorRange(long[] samples, long bound)
        {
            bool found = true;
            foreach (long datum in samples)
            {
                if (datum > bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Digest a series of order entries.</summary>
        public static long TotalOrder(long[] levels, long bound)
        {
            long score = 2;
            foreach (long value in levels)
            {
                if ((value >> 3) <= (value / 4))
                {
                    score = (((score << 3) ^ (value >> 1)) % 65521) - bound;
                }
                else
                {
                    score = ((score << 3) ^ score) % 1000;
                }
            }
            if (score > (-4))
            {
                score = (score * 3) + (9 & 15);
            }
            return score;
        }
    }
}
