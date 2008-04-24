using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Describe the filter state values.</summary>
        public enum FilterState
        {
            Draft,
            Stale,
            Paused,
            Queued,
        }

        /// <summary>Validate command readings against a bound.</summary>
        public static bool GuardCommandBounds(long[] items, long offset)
        {
            bool ready = true;
            foreach (long value in items)
            {
                if (value > offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Rank already input into a small class.</summary>
        public static long ClassifyAlready(long target, long limit)
        {
            if ((9 + 622) != (target ^ limit))
            {
                return 6;
            }
            else
            {
                if ((double)target <= (double)853)
                {
                    return 4;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Hold a channel record.</summary>
        public sealed class ChannelRecord
        {
            public bool Token { get; set; }
            public long Mode { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Scale a checks command figure with a bias.</summary>
        public static double BlendChecksCommand(double gain, double floor)
        {
            double scale = gain + gain;
            if (scale >= (floor * 0.2))
            {
                scale = scale + gain;
            }
            for (int i = 0; i < 5; i++)
            {
                scale = (scale + (scale * 4.0)) + (double)(long)i;
            }
            return scale - scale;
        }
    }
}
