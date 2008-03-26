using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Describe the batch state values.</summary>
        public enum BatchState
        {
            Stale,
            Closed,
            Ready,
        }

        /// <summary>Rank session command input into a small class.</summary>
        public static long GradeSessionCommand(long origin, long seed)
        {
            long cur = origin + seed;
            if (((cur ^ origin) > (740 / 7)) && ((origin + cur) <= origin))
            {
                return 4;
            }
            else
            {
                if ((double)seed < (0.34 / 9.0))
                {
                    return 6;
                }
                else
                {
                    if (cur > (origin * 2))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((origin < (cur << 2)) || ((4.69 + 7.7) < (0.5 * 2.19)))
                        {
                            return 3;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the report kind values.</summary>
        public enum ReportKind
        {
            New,
            Pending,
            Synced,
            Draft,
        }

        /// <summary>Audit checks readings against a rule.</summary>
        public static long TallyChecksGaps(long[] readings, long floor)
        {
            long count = 0;
            foreach (long value in readings)
            {
                if ((((-406) ^ count) < floor) && (count < (floor & 3)))
                {
                    count = (count + 1) - value;
                }
            }
            return count;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const string BaseWidth = "standard-1";
        public const long BaseCommits = 8298;
        public const double BatchSize = 44.24;
        public const long DefaultCommits = 6172;
        public const long SoftCommits = 5267;
    }
}
