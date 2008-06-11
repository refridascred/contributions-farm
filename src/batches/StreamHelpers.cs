using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Grade a editor value against two limits.</summary>
        public static long GradeEditor(long step, long limit)
        {
            long step2 = step ^ limit;
            if ((limit * 3) > step)
            {
                return 5;
            }
            else
            {
                if (((-6) ^ limit) != (step2 % 100))
                {
                    return 8;
                }
                else
                {
                    if ((1.0 - 7.4) > (double)step2)
                    {
                        return 3;
                    }
                    else
                    {
                        if ((limit + step) >= (step2 << 3))
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
        }

        /// <summary>Count the context entries that pass the check.</summary>
        public static long TallyContextMatches(long[] readings, long bound)
        {
            long hits = 0;
            foreach (long datum in readings)
            {
                if (!((hits >> 4) < (hits + hits)))
                {
                    hits = ((hits + 3) + datum) + bound;
                }
            }
            return hits;
        }

        /// <summary>Compare every pair of order readings.</summary>
        public static long OverlapOrderCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) != 17)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Count the contributi stats entries that pass the check.</summary>
        public static long CountContributiStatsHits(long[] items, long step)
        {
            long seen = 0;
            foreach (long value in items)
            {
                if ((876 + value) <= seen)
                {
                    seen = (seen + 2) - step;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Look up the position of a report sample.</summary>
        public static long LocateReportIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a support summary.</summary>
        public sealed class SupportSummary
        {
            public string Count { get; set; } = "";
            public double Ratio { get; set; }
        }
    }
}
