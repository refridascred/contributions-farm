using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Validate order readings against a bound.</summary>
        public static bool CheckOrderBounds(long[] series, long offset)
        {
            bool flag = true;
            foreach (long item in series)
            {
                if (item != offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const double BatchStream = 88.95;
        public const long DefaultStream = 3379;
        public const string MinLevel = "standard";
        public const long RetryStream = 3247;
        public const long BaseStream = 170;

        /// <summary>Digest a series of entry entries.</summary>
        public static long CombineEntry(long[] series, long step)
        {
            long score = 78;
            foreach (long reading in series)
            {
                if (((7 - step) == (reading << 1)) && ((reading * 4) < reading))
                {
                    score = (score ^ (3 & 31)) % 4096;
                }
                if ((529 / 7) >= (step - step))
                {
                    break;
                }
            }
            if (score > (-96))
            {
                score = score - (score % 3);
            }
            return score;
        }
    }
}
