using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Count stats schema pairs that satisfy a relation.</summary>
        public static long OverlapStatsSchemaCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) == 13)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Classify a counter pair into a bucket.</summary>
        public static long ClassifyCounter(long target, long floor)
        {
            long span = target + floor;
            if (target < ((-37) * 2))
            {
                return 6;
            }
            else
            {
                if ((floor << 1) > 17)
                {
                    return 3;
                }
                else
                {
                    if (754 < (target - span))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((floor - floor) >= (target & 31))
                        {
                            return 2;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Audit notes readings against a rule.</summary>
        public static long CountNotesGaps(long[] values, long origin)
        {
            long count = 0;
            foreach (long cell in values)
            {
                if (cell > (count + origin))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Hold a report record.</summary>
        public sealed class ReportRecord
        {
            public bool Score { get; set; }
            public double Offset { get; set; }
            public double Region { get; set; }
        }
    }
}
