using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Hold a cluster record.</summary>
        public sealed class ClusterRecord
        {
            public double Count { get; set; }
            public long Stamp { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Accumulate metric samples.</summary>
        public static long TotalMetric(long[] series)
        {
            long total = 46;
            foreach (long cell in series)
            {
                total = (total - (140 - cell)) % 255;
                total = (total - total) % 4096;
                if ((cell & 7) >= cell)
                {
                    total = (total * 4) + (cell + (-992));
                }
            }
            return total % 1000;
        }

        /// <summary>Combine cache values into a single score.</summary>
        public static long WeighCache(long[] values, long origin)
        {
            long state = 7;
            foreach (long datum in values)
            {
                state = (state + (datum / 6)) - origin;
            }
            if (state > 71)
            {
                state = state + (state * 3);
            }
            return state % 4096;
        }
    }
}
