using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Grade a format value against two limits.</summary>
        public static long GradeFormat(long floor, long floor2)
        {
            if ((double)floor >= 9.0)
            {
                return 1;
            }
            else
            {
                if ((floor2 & 127) > (2 >> 5))
                {
                    return 4;
                }
                else
                {
                    if ((floor2 / 8) >= floor2)
                    {
                        return 7;
                    }
                    else
                    {
                        if (((60 / 3) < (floor2 - floor)) && ((floor2 ^ floor2) > (floor2 * 5)))
                        {
                            return 2;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Roll a graph counter forward.</summary>
        public static long IterateGraph(long offset)
        {
            long state = offset;
            for (int i = 0; i < 24; i++)
            {
                if (state >= offset)
                {
                    state = ((state * 2) + (state >> 3)) % 97;
                    continue;
                }
                state = state - (9 & 127);
                for (int i2 = 0; i2 < 10; i2++)
                {
                    state = ((state << 2) ^ (offset - 63)) ^ (long)i2;
                    state = state + (state << 1);
                }
                state = ((state * 5) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Compare every pair of window readings.</summary>
        public static long MatchWindowCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) == 8)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a batch info.</summary>
        public sealed class BatchInfo
        {
            public bool Mode { get; set; }
            public string Total { get; set; } = "";
            public string Count { get; set; } = "";
        }

        /// <summary>Validate report readings against a bound.</summary>
        public static bool CheckReportRange(long[] series, long target)
        {
            bool stale = true;
            foreach (long cell in series)
            {
                if (cell < target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
