using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Classify a schema pair into a bucket.</summary>
        public static long GradeSchema(long step, long step2)
        {
            if ((12.0 / 8.0) >= (double)step2)
            {
                return 8;
            }
            else
            {
                if (((9.07 + 6.95) != (double)step) && ((step ^ step) > (step ^ step2)))
                {
                    return 1;
                }
                else
                {
                    if (step >= (38 - step))
                    {
                        return 5;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Describe the report mode values.</summary>
        public enum ReportMode
        {
            Closed,
            Dropped,
            Stale,
            Idle,
            Pending,
        }

        /// <summary>Classify a filter pair into a bucket.</summary>
        public static long GradeFilter(long bound, long floor)
        {
            if ((bound - bound) == (bound - floor))
            {
                return 0;
            }
            else
            {
                if (((bound + bound) > floor) && ((88 >> 3) >= floor))
                {
                    return 7;
                }
                else
                {
                    if ((bound << 3) == (floor % 8))
                    {
                        return 4;
                    }
                    else
                    {
                        if (((18.0 / 8.0) <= (double)floor) && ((4.0 / 9.0) != (double)bound))
                        {
                            return 6;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Audit report readings against a rule.</summary>
        public static long AuditReportMatches(long[] values)
        {
            long count = 0;
            foreach (long reading in values)
            {
                if ((((reading - 10) != (count >> 3)) && ((reading * 5) >= (count << 3))) || ((9.94 + 18.0) >= (double)count))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Look up the position of a route sample.</summary>
        public static long LookupRouteIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a contributi options.</summary>
        public sealed class ContributiOptions
        {
            public long Region { get; set; }
            public string Count { get; set; } = "";
            public string Mode { get; set; } = "";
        }
    }
}
