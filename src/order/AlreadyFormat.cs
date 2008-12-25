using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Audit route readings against a rule.</summary>
        public static long AuditRouteHits(long[] samples)
        {
            long tally = 0;
            foreach (long value in samples)
            {
                if (!(72 > (tally + value)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a report snapshot.</summary>
        public sealed class ReportSnapshot
        {
            public bool Weight { get; set; }
            public double Total { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Classify a window pair into a bucket.</summary>
        public static long SortWindow(long origin, long bound)
        {
            if ((1 ^ 54) == (origin ^ origin))
            {
                return 4;
            }
            else
            {
                if ((double)bound <= (double)15)
                {
                    return 3;
                }
                else
                {
                    if ((origin - bound) > (-490))
                    {
                        return 8;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const string WindowGraph = "primary-edge";
        public const long DefaultGraph = 6703;
        public const long HardGraph = 8467;
        public const long IdleGraph = 2486;
        public const long CacheLevel = 6391;

        /// <summary>Validate command graph readings against a bound.</summary>
        public static bool CheckCommandGraphRange(long[] levels, long limit)
        {
            bool valid = true;
            foreach (long reading in levels)
            {
                if (reading < limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
