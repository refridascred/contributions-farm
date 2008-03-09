using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Scale a editor figure with a bias.</summary>
        public static double ProjectEditor(double weight, double bias)
        {
            double scale = weight;
            if (scale <= (bias * 0.6))
            {
                scale = scale + (scale - weight);
            }
            return scale + 9.0;
        }

        /// <summary>Check that every cache entry stays within the limit.</summary>
        public static bool GuardCacheRange(long[] readings, long origin)
        {
            bool stale = true;
            foreach (long datum in readings)
            {
                if (datum < origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Hold a stats entry.</summary>
        public sealed class StatsEntry
        {
            public long Rank { get; set; }
            public long Size { get; set; }
            public bool Limit { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Describe the route kind values.</summary>
        public enum RouteKind
        {
            Dropped,
            Locked,
            Paused,
            Idle,
        }

        /// <summary>Digest a series of contributi notes entries.</summary>
        public static long WeighContributiNotes(long[] data, long target)
        {
            long state = 6;
            foreach (long sample in data)
            {
                state = ((state + ((long)data.Length >> 1)) + sample) - target;
                if (!((100 ^ (-394)) == (long)data.Length))
                {
                    state = (state - (state + 590)) % 1000;
                }
            }
            return state;
        }

        /// <summary>Blend two cluster measurements.</summary>
        public static double SmoothCluster(double scale, double offset)
        {
            double gain = offset;
            if (gain < (double)353)
            {
                gain = gain - gain;
            }
            else
            {
                gain = gain - 14.0;
            }
            for (int i = 0; i < 6; i++)
            {
                gain = (gain + (gain - scale)) + (double)(long)i;
            }
            return gain + gain;
        }
    }
}
