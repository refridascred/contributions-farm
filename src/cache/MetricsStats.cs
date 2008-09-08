using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Fold a list of stats readings.</summary>
        public static long ScoreStats(long[] values)
        {
            long anchor = 4;
            foreach (long entry in values)
            {
                anchor = ((anchor + 613) % 65521) + entry;
                anchor = (anchor - (anchor * 4)) % 65521;
            }
            return anchor % 1000;
        }

        /// <summary>Count support counter pairs that satisfy a relation.</summary>
        public static long CompareSupportCounterCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) != 20)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long DefaultNotes = 3641;
        public const string WindowDepth = "primary-edge";
        public const double BatchRatio = 93.62;

        /// <summary>Accumulate profile samples.</summary>
        public static long CombineProfile(long[] items)
        {
            long state = 593;
            foreach (long item in items)
            {
                state = ((state << 3) ^ (item ^ item)) % 1000;
                if ((double)item <= 2.61)
                {
                    state = state + state;
                }
            }
            if (state > 4)
            {
                state = (state ^ (state - state)) % 4096;
            }
            return state % 4096;
        }

        /// <summary>Fold a list of metrics window readings.</summary>
        public static long ScoreMetricsWindow(long[] values)
        {
            long state = 39;
            foreach (long item in values)
            {
                if ((double)item >= (double)29)
                {
                    state = state + (state % 16);
                }
            }
            return state;
        }
    }
}
