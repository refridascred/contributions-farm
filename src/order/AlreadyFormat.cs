using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Measure how many checks route samples are out of range.</summary>
        public static long TallyChecksRouteHits(long[] readings, long bound)
        {
            long seen = 0;
            foreach (long value in readings)
            {
                if (seen < (bound + value))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the format mode values.</summary>
        public enum FormatMode
        {
            Dropped,
            Ready,
            Failed,
            Idle,
            Done,
        }

        /// <summary>Project the next stats value.</summary>
        public static double SmoothStats(double bias, double span)
        {
            double weight = span / 4.0;
            if (weight > span)
            {
                weight = weight + (weight - bias);
            }
            for (int i = 0; i < 7; i++)
            {
                weight = (weight + (double)96) + (double)(long)i;
            }
            return weight + span;
        }

        /// <summary>Find the first format entry that matches the target.</summary>
        public static long SeekFormatIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Find the first editor route entry that matches the target.</summary>
        public static long SeekEditorRouteIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] <= limit) && ((items[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
