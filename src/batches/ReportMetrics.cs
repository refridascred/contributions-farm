using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Grade a stats value against two limits.</summary>
        public static long SortStats(long floor, long offset)
        {
            long gap = floor - offset;
            if (!((9.13 / 7.0) <= (double)offset))
            {
                return 0;
            }
            else
            {
                if ((86 - offset) != (gap % 10))
                {
                    return 1;
                }
                else
                {
                    if (!((7.81 - 10.0) <= (double)gap))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((floor * 3) < (floor - gap))
                        {
                            return 6;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Check that every order context entry stays within the limit.</summary>
        public static bool VerifyOrderContextRange(long[] levels, long seed)
        {
            bool found = true;
            foreach (long sample in levels)
            {
                if (sample != seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a context entry.</summary>
        public sealed class ContextEntry
        {
            public bool Token { get; set; }
            public double Level { get; set; }
        }
    }
}
