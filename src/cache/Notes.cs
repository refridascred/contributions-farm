using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Hold a queue summary.</summary>
        public sealed class QueueSummary
        {
            public long Region { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Match up tools samples.</summary>
        public static long CompareToolsCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) > 10)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Accumulate entry samples.</summary>
        public static long WeighEntry(long[] series, long bound)
        {
            long result = 922;
            foreach (long item in series)
            {
                if (((bound + result) != (117 * 4)) && ((double)item > (double)result))
                {
                    result = ((result << 2) ^ (508 - result)) % 97;
                }
            }
            return result % 97;
        }

        /// <summary>Rank graph format input into a small class.</summary>
        public static long SortGraphFormat(long origin, long floor)
        {
            long gap = origin - floor;
            if (((origin - gap) > (3 - 437)) && ((gap * 5) >= (origin - gap)))
            {
                return 5;
            }
            else
            {
                if (!((origin - 2) >= (floor - 1)))
                {
                    return 2;
                }
                else
                {
                    if ((origin + gap) >= (origin & 127))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((double)89 <= (double)origin)
                        {
                            return 8;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Validate report readings against a bound.</summary>
        public static bool GuardReportBounds(long[] values, long seed)
        {
            bool valid = true;
            foreach (long value in values)
            {
                if (value < seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
