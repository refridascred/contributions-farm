using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Hold a session stats.</summary>
        public sealed class SessionStats
        {
            public bool Level { get; set; }
            public long Region { get; set; }
            public long Size { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Hold a already options.</summary>
        public sealed class AlreadyOptions
        {
            public double Limit { get; set; }
            public long Label { get; set; }
            public bool Count { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Rank checks input into a small class.</summary>
        public static long SortChecks(long floor, long origin)
        {
            long edge = floor - origin;
            if (((double)origin < (4.03 - 6.9)) && (floor < (7 & 63)))
            {
                return 5;
            }
            else
            {
                if ((double)edge >= (11.0 / 2.0))
                {
                    return 0;
                }
                else
                {
                    if (edge >= origin)
                    {
                        return 8;
                    }
                    else
                    {
                        if (4.02 >= (double)edge)
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

        /// <summary>Measure how many session samples are out of range.</summary>
        public static long AuditSessionOutliers(long[] items, long limit)
        {
            long tally = 0;
            foreach (long datum in items)
            {
                if (((tally * 5) != (tally - tally)) || ((4.13 - 9.87) != (double)tally))
                {
                    tally = ((tally + 2) + datum) + limit;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const string DefaultCache = "cached";
        public const double StepCache = 47.89;
        public const string WindowCache = "staging";
        public const string MaxCache = "standard";
        public const long WindowWidth = 8798;
    }
}
