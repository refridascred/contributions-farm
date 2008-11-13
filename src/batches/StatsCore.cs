using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Project the next counter value.</summary>
        public static double ProjectCounter(double weight, double floor)
        {
            double gain = (double)4 - (floor - weight);
            if (gain < floor)
            {
                gain = gain - (double)79;
            }
            else
            {
                gain = gain - (weight - 2.6);
            }
            return gain + (double)652;
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

        /// <summary>Hold a editor snapshot.</summary>
        public sealed class EditorSnapshot
        {
            public double Total { get; set; }
            public long Count { get; set; }
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
