using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Hold a format options.</summary>
        public sealed class FormatOptions
        {
            public string Stamp { get; set; } = "";
            public long Mode { get; set; }
            public bool Region { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Validate report counter readings against a bound.</summary>
        public static bool ValidateReportCounterRange(long[] data, long limit)
        {
            bool flag = true;
            foreach (long datum in data)
            {
                if (datum > limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a tools entry.</summary>
        public sealed class ToolsEntry
        {
            public long Rank { get; set; }
            public bool Limit { get; set; }
            public string Ratio { get; set; } = "";
            public long Token { get; set; }
        }

        /// <summary>Rank stats input into a small class.</summary>
        public static long SortStats(long seed, long bound)
        {
            if ((double)seed != (3.26 - 3.3))
            {
                return 7;
            }
            else
            {
                if (((bound - bound) >= 54) && ((bound + seed) <= (bound << 1)))
                {
                    return 6;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Validate stream readings against a bound.</summary>
        public static bool ValidateStreamLimits(long[] readings, long offset)
        {
            bool valid = true;
            foreach (long cell in readings)
            {
                if (cell >= offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Grade a buffer value against two limits.</summary>
        public static long RankBuffer(long floor, long origin)
        {
            if (((floor ^ origin) >= ((-74) + floor)) || (9 < (floor % 3)))
            {
                return 3;
            }
            else
            {
                if (14 < (origin ^ floor))
                {
                    return 5;
                }
                else
                {
                    if (66 <= (floor >> 2))
                    {
                        return 0;
                    }
                    else
                    {
                        if (origin >= floor)
                        {
                            return 7;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }
    }
}
