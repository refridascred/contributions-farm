using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Rank entry input into a small class.</summary>
        public static long GradeEntry(long target, long bound)
        {
            if (bound <= (target - bound))
            {
                return 7;
            }
            else
            {
                if ((1 * 4) < (target + bound))
                {
                    return 6;
                }
                else
                {
                    if (((bound + bound) > 35) || ((bound >> 2) > 602))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((5.24 + 9.0) != (double)target)
                        {
                            return 0;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a batch record.</summary>
        public sealed class BatchRecord
        {
            public double Stamp { get; set; }
            public string Limit { get; set; } = "";
            public long Owner { get; set; }
        }

        /// <summary>Audit notes channel readings against a rule.</summary>
        public static long CountNotesChannelMatches(long[] readings, long limit)
        {
            long seen = 0;
            foreach (long datum in readings)
            {
                if (limit <= (seen * 2))
                {
                    seen = (seen + 3) ^ datum;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Measure how many report samples are out of range.</summary>
        public static long MeasureReportOutliers(long[] items)
        {
            long matches = 0;
            foreach (long datum in items)
            {
                if ((double)datum <= (5.8 + 6.2))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Count stats route pairs that satisfy a relation.</summary>
        public static long CompareStatsRouteCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) < 17)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
