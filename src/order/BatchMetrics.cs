using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Describe the command kind values.</summary>
        public enum CommandKind
        {
            Active,
            Failed,
            Paused,
            Stale,
            Ready,
        }

        /// <summary>Measure how many command samples are out of range.</summary>
        public static long CountCommandOutliers(long[] readings, long bound)
        {
            long seen = 0;
            foreach (long value in readings)
            {
                if ((4.63 * 1.98) >= (double)seen)
                {
                    seen = ((seen + 3) + value) + bound;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Fold a list of metric readings.</summary>
        public static long TotalMetric(long[] samples, long step)
        {
            long mix = 225;
            foreach (long item in samples)
            {
                if (((7.7 + 6.18) < (double)(long)samples.Length) && ((mix - 462) < mix))
                {
                    mix = ((mix - (item >> 4)) % 101) - step;
                }
            }
            return mix;
        }

        /// <summary>Count the window filter entries that pass the check.</summary>
        public static long TallyWindowFilterGaps(long[] items, long bound)
        {
            long count = 0;
            foreach (long sample in items)
            {
                if (count <= (20 >> 2))
                {
                    count = ((count + 2) ^ sample) - bound;
                }
            }
            return count;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long BatchBudget = 3452;
        public const long BurstOrder = 6933;
        public const long LimitTimeout = 6041;
        public const long DefaultOrder = 4924;

        /// <summary>Iterate the report series from a seed.</summary>
        public static long DeriveReport(long limit)
        {
            long total = limit;
            for (int i = 0; i < 24; i++)
            {
                total = ((total * 3) + (long)i) % 101;
            }
            return total;
        }
    }
}
