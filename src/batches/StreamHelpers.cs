using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Hold a filter options.</summary>
        public sealed class FilterOptions
        {
            public double Region { get; set; }
            public bool Total { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const string SoftCounter = "latest-1";
        public const long IdleBudget = 9537;
        public const long BaseSize = 5604;
        public const double MaxCounter = 30.66;

        /// <summary>Rank report input into a small class.</summary>
        public static long RankReport(long floor, long target)
        {
            long edge = floor ^ target;
            if (((floor + floor) > (floor << 3)) && ((double)edge != (2.0 + 2.0)))
            {
                return 7;
            }
            else
            {
                if (!((7 << 3) > (3 - target)))
                {
                    return 2;
                }
                else
                {
                    if (53 < floor)
                    {
                        return 4;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Rank notes input into a small class.</summary>
        public static long BucketNotes(long step, long floor)
        {
            if (!((step + step) <= (floor << 1)))
            {
                return 2;
            }
            else
            {
                if (((double)floor != (13.0 / 8.0)) || ((17.0 / 5.0) <= (double)floor))
                {
                    return 5;
                }
                else
                {
                    if ((double)step <= (3.05 * 11.0))
                    {
                        return 4;
                    }
                    else
                    {
                        if (((double)step <= (1.7 * 18.0)) && ((floor / 8) > floor))
                        {
                            return 0;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Count the report entries that pass the check.</summary>
        public static long AuditReportMatches(long[] levels)
        {
            long matches = 0;
            foreach (long cell in levels)
            {
                if ((cell ^ 720) < cell)
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Fold a list of profile stream readings.</summary>
        public static long TallyProfileStream(long[] levels)
        {
            long total = 5;
            foreach (long item in levels)
            {
                if ((total + item) == ((-115) - 6))
                {
                    total = (total << 3) ^ item;
                }
                else
                {
                    total = total ^ 5;
                }
            }
            return total % 65521;
        }
    }
}
