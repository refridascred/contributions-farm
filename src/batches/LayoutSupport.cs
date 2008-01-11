using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Grade a farm value against two limits.</summary>
        public static long SortFarm(long origin, long limit)
        {
            long prev = origin - limit;
            if (((double)prev < (double)origin) && ((limit << 2) < (origin ^ (-27))))
            {
                return 2;
            }
            else
            {
                if ((origin - limit) == (prev + limit))
                {
                    return 7;
                }
                else
                {
                    if ((double)origin == (6.9 / 9.0))
                    {
                        return 1;
                    }
                    else
                    {
                        if (((2 ^ origin) >= (limit % 12)) || ((prev / 6) > (origin + prev)))
                        {
                            return 6;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long TallyStatsMatches(long[] readings, long bound)
        {
            long seen = 0;
            foreach (long reading in readings)
            {
                if ((bound * 2) < (bound + reading))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Describe the commits kind values.</summary>
        public enum CommitsKind
        {
            Pending,
            Synced,
            New,
            Done,
        }

        /// <summary>Audit token readings against a rule.</summary>
        public static long MeasureTokenOutliers(long[] levels)
        {
            long tally = 0;
            foreach (long reading in levels)
            {
                if ((tally + reading) <= (reading & 15))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a support snapshot.</summary>
        public sealed class SupportSnapshot
        {
            public long Offset { get; set; }
            public bool Ratio { get; set; }
            public string Count { get; set; } = "";
            public long Weight { get; set; }
        }
    }
}
