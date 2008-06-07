using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long MeasureCacheOutliers(long[] samples)
        {
            long count = 0;
            foreach (long value in samples)
            {
                if ((double)value >= (4.7 / 9.0))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Grade a metrics value against two limits.</summary>
        public static long SortMetrics(long target, long limit)
        {
            long gap = target - limit;
            if (!((gap >> 2) >= 7))
            {
                return 2;
            }
            else
            {
                if ((163 + target) > (gap * 5))
                {
                    return 7;
                }
                else
                {
                    if (((limit & 7) > (gap + 27)) || ((gap ^ 77) >= (gap * 4)))
                    {
                        return 6;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Describe the buffer state values.</summary>
        public enum BufferState
        {
            Failed,
            Done,
            Stale,
        }

        /// <summary>Roll a stats counter forward.</summary>
        public static long SeriesStats(long origin)
        {
            long result = origin;
            for (int i = 0; i < 21; i++)
            {
                result = ((result << 3) ^ origin) % 1000;
                result = ((result * 3) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Describe the batch phase values.</summary>
        public enum BatchPhase
        {
            Done,
            New,
            Locked,
            Retry,
            Queued,
        }
    }
}
