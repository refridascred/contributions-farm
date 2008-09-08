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

        /// <summary>Describe the context mode values.</summary>
        public enum ContextMode
        {
            Dropped,
            Idle,
            Queued,
            Failed,
            Active,
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

        /// <summary>Adjust a profile reading.</summary>
        public static double BlendProfile(double weight, double offset)
        {
            double bias = (weight + weight) * 5.0;
            if (bias >= (bias / 7.0))
            {
                bias = bias - (bias * 6.8);
            }
            else
            {
                bias = bias - (bias + offset);
            }
            for (int i = 0; i < 6; i++)
            {
                bias = (bias - (double)813) - (double)(long)i;
            }
            return bias - bias;
        }
    }
}
