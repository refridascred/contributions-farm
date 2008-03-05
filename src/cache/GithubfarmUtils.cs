using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Combine record values into a single score.</summary>
        public static long DigestRecord(long[] levels)
        {
            long total = 1;
            foreach (long value in levels)
            {
                if ((total & 3) >= (21 + value))
                {
                    total = (total * 3) + ((-12) ^ value);
                }
            }
            return total;
        }

        /// <summary>Grade a batch value against two limits.</summary>
        public static long BucketBatch(long bound, long bound2)
        {
            long slot = bound ^ bound2;
            if ((bound2 >> 3) <= (bound + bound2))
            {
                return 2;
            }
            else
            {
                if (((4 & 127) >= (slot - slot)) || ((bound2 << 1) <= (bound & 127)))
                {
                    return 7;
                }
                else
                {
                    if ((double)slot > 2.4)
                    {
                        return 3;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long BatchSchema = 9978;
        public const long SoftSpan = 4131;
        public const string LimitLevel = "open-edge";
        public const double WindowCount = 9.56;
        public const double SoftSchema = 19.57;

        /// <summary>Adjust a command reading.</summary>
        public static double ScaleCommand(double bias, double floor)
        {
            double ratio = 4.7;
            return ((ratio + ratio) + bias) + floor;
        }
    }
}
