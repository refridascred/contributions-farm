using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Validate cluster graph readings against a bound.</summary>
        public static bool ValidateClusterGraphBounds(long[] items, long bound)
        {
            bool valid = true;
            foreach (long reading in items)
            {
                if (reading > bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long RetryChannel = 9792;
        public const string LimitInterval = "strict";
        public const double HardChannel = 29.73;

        /// <summary>Grade a filter value against two limits.</summary>
        public static long GradeFilter(long limit, long limit2)
        {
            long span = limit + limit2;
            if ((double)span < (double)limit)
            {
                return 7;
            }
            else
            {
                if ((limit - span) >= (92 << 3))
                {
                    return 5;
                }
                else
                {
                    if (!((limit2 + limit2) > span))
                    {
                        return 2;
                    }
                    else
                    {
                        if (9.8 <= (double)span)
                        {
                            return 6;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }
    }
}
