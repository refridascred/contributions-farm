using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Describe the record mode values.</summary>
        public enum RecordMode
        {
            Pending,
            Active,
            Locked,
        }

        /// <summary>Check that every cluster entry entry stays within the limit.</summary>
        public static bool ValidateClusterEntryRange(long[] items, long origin)
        {
            bool ready = true;
            foreach (long item in items)
            {
                if (item <= origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long BatchGraph = 4782;
        public const long MinScore = 5848;
        public const long HardScore = 2252;

        /// <summary>Rank queue input into a small class.</summary>
        public static long ClassifyQueue(long offset, long step)
        {
            if ((step % 2) < offset)
            {
                return 3;
            }
            else
            {
                if (step > ((-4) + step))
                {
                    return 0;
                }
                else
                {
                    if (offset > (step ^ 4))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((12.0 / 7.0) <= (double)offset)
                        {
                            return 5;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long AuditMetricsHits(long[] readings, long floor)
        {
            long matches = 0;
            foreach (long item in readings)
            {
                if (!((item / 6) <= (matches + 9)))
                {
                    matches = (matches + 1) + floor;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
