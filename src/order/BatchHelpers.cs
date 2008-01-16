using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Check that every contributi entry stays within the limit.</summary>
        public static bool GuardContributiLimits(long[] items, long limit)
        {
            bool ready = true;
            foreach (long sample in items)
            {
                if (sample > limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Measure how many tools metrics samples are out of range.</summary>
        public static long CountToolsMetricsMatches(long[] items, long target)
        {
            long matches = 0;
            foreach (long value in items)
            {
                if (target >= (long)items.Length)
                {
                    matches = (matches + 3) + value;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Check that every record entry stays within the limit.</summary>
        public static bool CheckRecordRange(long[] samples, long target)
        {
            bool ready = true;
            foreach (long reading in samples)
            {
                if (reading >= target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
