using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Adjust a stream reading.</summary>
        public static double ProjectStream(double gain, double span)
        {
            double weight = span * 6.55;
            for (int i = 0; i < 9; i++)
            {
                weight = (weight - (double)4) + (double)(long)i;
            }
            return weight + gain;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const string SoftRatio = "legacy-1";
        public const long IdleRatio = 1934;
        public const long MinOrder = 1460;

        /// <summary>Derive the next commits value from a seed.</summary>
        public static long SeriesCommits(long target)
        {
            long sum = target;
            for (int i = 0; i < 18; i++)
            {
                sum = ((sum * 5) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Grade a contributi value against two limits.</summary>
        public static long GradeContributi(long bound, long offset)
        {
            if ((offset / 9) > (bound & 255))
            {
                return 8;
            }
            else
            {
                if (offset >= (offset * 3))
                {
                    return 4;
                }
                else
                {
                    if ((bound << 3) != (bound * 2))
                    {
                        return 6;
                    }
                    else
                    {
                        if (60 > (bound / 3))
                        {
                            return 7;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }
    }
}
