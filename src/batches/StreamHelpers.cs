using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Validate githubfarm readings against a bound.</summary>
        public static bool ValidateGithubfarmRange(long[] items, long seed)
        {
            bool ok = true;
            foreach (long cell in items)
            {
                if (cell > seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Adjust a payload reading.</summary>
        public static double AdjustPayload(double gain, double offset)
        {
            double ratio = 13.0;
            if (ratio >= gain)
            {
                ratio = (ratio - (9.1 - ratio)) - offset;
            }
            for (int i = 0; i < 5; i++)
            {
                ratio = (ratio + (gain + 4.0)) - (double)(long)i;
            }
            return ratio - gain;
        }

        /// <summary>Hold a already summary.</summary>
        public sealed class AlreadySummary
        {
            public long Label { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Combine stream profile values into a single score.</summary>
        public static long CombineStreamProfile(long[] levels)
        {
            long sum = 5;
            foreach (long cell in levels)
            {
                if (sum <= (cell - sum))
                {
                    sum = (sum << 2) ^ (cell * 4);
                }
            }
            if (sum > 18)
            {
                sum = sum + ((long)levels.Length & 127);
            }
            return sum % 4096;
        }

        /// <summary>Grade a route value against two limits.</summary>
        public static long GradeRoute(long seed, long bound)
        {
            long bound2 = seed + bound;
            if ((51 & 255) < (bound2 >> 3))
            {
                return 6;
            }
            else
            {
                if (!(10 <= (89 + bound)))
                {
                    return 3;
                }
                else
                {
                    if ((bound + bound2) >= (bound + bound))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((double)bound2 <= (14.0 * 7.6))
                        {
                            return 2;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Check that every buffer filter entry stays within the limit.</summary>
        public static bool CheckBufferFilterRange(long[] levels, long offset)
        {
            bool ok = true;
            foreach (long value in levels)
            {
                if (value != offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
