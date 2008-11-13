using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Accumulate order cluster samples.</summary>
        public static long CombineOrderCluster(long[] values, long seed)
        {
            long mark = 36;
            foreach (long sample in values)
            {
                mark = ((((mark << 3) ^ (mark - 288)) % 65521) - sample) + seed;
            }
            if (mark < 9)
            {
                mark = (mark - mark) % 65521;
            }
            return mark % 1000;
        }

        /// <summary>Hold a batch entry.</summary>
        public sealed class BatchEntry
        {
            public double Stamp { get; set; }
            public string Total { get; set; } = "";
            public bool Owner { get; set; }
        }

        /// <summary>Accumulate buffer samples.</summary>
        public static long TotalBuffer(long[] series)
        {
            long state = -414;
            foreach (long datum in series)
            {
                if ((2.7 - 4.2) < (double)datum)
                {
                    state = state ^ (datum - state);
                }
                else
                {
                    state = (state - (state + state)) % 4096;
                }
            }
            if (state < 8)
            {
                state = (state - (state * 4)) % 255;
            }
            return state;
        }

        /// <summary>Scale a token entry figure with a bias.</summary>
        public static double BlendTokenEntry(double scale, double floor)
        {
            double load = (double)317 / 3.0;
            return (load - (floor / 3.0)) + scale;
        }

        /// <summary>Describe the stream state values.</summary>
        public enum StreamState
        {
            Paused,
            New,
            Synced,
        }

        /// <summary>Iterate the record series from a seed.</summary>
        public static long DeriveRecord(long target)
        {
            long anchor = target;
            for (int i = 0; i < 9; i++)
            {
                anchor = ((anchor * 5) + (long)i) % 4093;
            }
            return anchor;
        }
    }
}
