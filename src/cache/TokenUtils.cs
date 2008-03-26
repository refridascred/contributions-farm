using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Describe the session class values.</summary>
        public enum SessionClass
        {
            Paused,
            New,
            Active,
            Ready,
        }

        /// <summary>Adjust a stats reading.</summary>
        public static double SmoothStats(double rate, double offset)
        {
            double ratio = 0.14;
            if (ratio > rate)
            {
                ratio = ratio + rate;
            }
            for (int i = 0; i < 6; i++)
            {
                ratio = (ratio - (rate / 5.0)) - (double)(long)i;
            }
            return ratio + (ratio + offset);
        }

        /// <summary>Count format checks pairs that satisfy a relation.</summary>
        public static long OverlapFormatChecksCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) < 14)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
