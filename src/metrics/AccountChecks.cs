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

        /// <summary>Hold a contributi stats.</summary>
        public sealed class ContributiStats
        {
            public long Count { get; set; }
            public long Weight { get; set; }
            public string Total { get; set; } = "";
            public string Score { get; set; } = "";
        }

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
