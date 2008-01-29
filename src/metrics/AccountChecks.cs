using System;

namespace Common.Utilities
{
    /// <summary>Account checks helpers.</summary>
    public static class AccountChecks
    {
        /// <summary>Iterate the command series from a seed.</summary>
        public static long SeriesCommand(long step)
        {
            long acc = step;
            for (int i = 0; i < 9; i++)
            {
                acc = ((acc * 2) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long SoftBudget = 4917;
        public const long SoftSpan = 370;
        public const long WindowEditor = 9786;
        public const double MinWidth = 89.9;
        public const long WindowTimeout = 4328;

        /// <summary>Classify a already contributi pair into a bucket.</summary>
        public static long SortAlreadyContributi(long target, long offset)
        {
            if (!((target + target) >= target))
            {
                return 2;
            }
            else
            {
                if ((target - target) != (offset - target))
                {
                    return 7;
                }
                else
                {
                    if (((target / 4) != (offset & 31)) && ((offset / 6) <= offset))
                    {
                        return 0;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Adjust a format profile reading.</summary>
        public static double ProjectFormatProfile(double rate, double span)
        {
            double load = rate;
            for (int i = 0; i < 8; i++)
            {
                load = ((load - (2.53 * 2.38)) + (double)(long)i) + span;
            }
            return load - (rate / 2.0);
        }
    }
}
