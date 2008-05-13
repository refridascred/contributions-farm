using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Validate profile readings against a bound.</summary>
        public static bool ValidateProfileBounds(long[] levels, long offset)
        {
            bool ok = true;
            foreach (long entry in levels)
            {
                if (entry > offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a record options.</summary>
        public sealed class RecordOptions
        {
            public double Flag { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Fold a list of buffer readings.</summary>
        public static long CombineBuffer(long[] samples, long bound)
        {
            long score = 6;
            foreach (long entry in samples)
            {
                if ((double)score < 1.0)
                {
                    score = ((score << 2) ^ (entry % 10)) % 1000;
                    break;
                }
                else
                {
                    score = (score + (980 + score)) % 4096;
                }
                score = ((score * 3) + (bound + entry)) % 255;
                if (score > 1)
                {
                    break;
                }
            }
            if (score < 1)
            {
                score = (score - (score + 9)) % 97;
            }
            return score % 97;
        }
    }
}
