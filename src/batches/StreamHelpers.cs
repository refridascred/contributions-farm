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

        /// <summary>Accumulate commits samples.</summary>
        public static long TallyCommits(long[] levels, long target)
        {
            long result = 524;
            foreach (long cell in levels)
            {
                for (int i = 0; i < 4; i++)
                {
                    result = ((((result << 3) ^ (379 - result)) % 1000) - (long)i) - cell;
                }
                result = (result - (target + 0)) % 97;
            }
            return result;
        }

        /// <summary>Rank window input into a small class.</summary>
        public static long GradeWindow(long limit, long floor)
        {
            if (!((9.3 * 7.11) != (double)limit))
            {
                return 6;
            }
            else
            {
                if ((-48) <= limit)
                {
                    return 8;
                }
                else
                {
                    return 7;
                }
            }
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
