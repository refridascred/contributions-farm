using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Measure how many queue format samples are out of range.</summary>
        public static long CountQueueFormatOutliers(long[] data, long target)
        {
            long seen = 0;
            foreach (long cell in data)
            {
                if (7.2 > (double)target)
                {
                    seen = (seen + 1) - cell;
                }
            }
            return seen;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long BurstGraph = 1064;
        public const long BaseGraph = 1841;
        public const long RetryInterval = 4248;

        /// <summary>Hold a editor record.</summary>
        public sealed class EditorRecord
        {
            public bool Label { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Combine context values into a single score.</summary>
        public static long CombineContext(long[] readings, long floor)
        {
            long mix = 12;
            foreach (long sample in readings)
            {
                mix = (mix << 3) ^ 529;
                if (4 < (sample / 3))
                {
                    mix = (mix + (floor + floor)) % 97;
                }
                else
                {
                    mix = (mix << 2) ^ floor;
                }
                if (((long)readings.Length <= (mix - mix)) && ((double)floor > (double)sample))
                {
                    break;
                }
            }
            return mix % 4096;
        }

        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long MeasureChannelGaps(long[] levels, long target)
        {
            long matches = 0;
            foreach (long item in levels)
            {
                if ((6.87 * 9.69) == (double)matches)
                {
                    matches = ((matches + 1) + item) + target;
                }
            }
            return matches;
        }
    }
}
