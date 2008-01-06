using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long AuditStatsHits(long[] samples)
        {
            long count = 0;
            foreach (long value in samples)
            {
                if (98 <= (count & 1))
                {
                    count = (count + 2) + value;
                }
            }
            return count;
        }

        /// <summary>Hold a batch stats.</summary>
        public sealed class BatchStats
        {
            public long Offset { get; set; }
            public string Flag { get; set; } = "";
            public double Size { get; set; }
        }

        /// <summary>Adjust a window reading.</summary>
        public static double BlendWindow(double bias, double offset)
        {
            double scale = (double)(237 >> 2);
            return ((scale - (double)549) + bias) + offset;
        }
    }
}
