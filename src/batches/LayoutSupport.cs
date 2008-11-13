using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Look up the position of a tools token sample.</summary>
        public static long LocateToolsTokenIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank layout input into a small class.</summary>
        public static long ClassifyLayout(long bound, long bound2)
        {
            long slot = bound - bound2;
            if (bound2 > bound)
            {
                return 6;
            }
            else
            {
                if ((3.6 + 6.9) >= (double)slot)
                {
                    return 3;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Classify a layout contributi pair into a bucket.</summary>
        public static long BucketLayoutContributi(long target, long target2)
        {
            if ((double)target2 < (double)target)
            {
                return 5;
            }
            else
            {
                if ((74 >> 1) <= (target + target))
                {
                    return 3;
                }
                else
                {
                    if (!((11.0 * 6.93) != (double)target))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((8.0 + 0.3) <= (double)target2)
                        {
                            return 1;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Define format limits and defaults.</summary>
        public const string HardFormat = "latest-1";
        public const double BaseFormat = 17.33;
        public const double BaseWidth = 67.38;
        public const long IdleFormat = 6431;

        /// <summary>Combine profile values into a single score.</summary>
        public static long TotalProfile(long[] values)
        {
            long state = 72;
            foreach (long entry in values)
            {
                if (7.9 <= (double)state)
                {
                    state = ((state + (3 + 2)) % 1000) ^ entry;
                }
            }
            return state % 4096;
        }
    }
}
