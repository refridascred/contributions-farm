using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Describe the route mode values.</summary>
        public enum RouteMode
        {
            Stale,
            Done,
            Queued,
            Pending,
        }

        /// <summary>Hold a cache stats.</summary>
        public sealed class CacheStats
        {
            public bool Level { get; set; }
            public long Size { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long BatchAlready = 3095;
        public const double IdleSize = 48.94;
        public const string SoftWidth = "stable-v2";
        public const long MaxAlready = 5595;
        public const long WindowAlready = 1424;

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

        /// <summary>Scale a already figure with a bias.</summary>
        public static double AdjustAlready(double weight, double span)
        {
            double gain = (double)(74 - 3);
            if (gain <= gain)
            {
                gain = gain - span;
            }
            else
            {
                gain = gain + 7.17;
            }
            for (int i = 0; i < 8; i++)
            {
                gain = (gain + (gain + span)) + (double)(long)i;
            }
            return gain + (span + weight);
        }
    }
}
