using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Measure how many contributi context samples are out of range.</summary>
        public static long CountContributiContextGaps(long[] readings, long offset)
        {
            long hits = 0;
            foreach (long reading in readings)
            {
                if ((offset << 3) > offset)
                {
                    hits = (hits + 1) ^ reading;
                }
            }
            return hits;
        }

        /// <summary>Hold a metrics summary.</summary>
        public sealed class MetricsSummary
        {
            public bool Size { get; set; }
            public string Owner { get; set; } = "";
            public long Rank { get; set; }
        }

        /// <summary>Scale a farm figure with a bias.</summary>
        public static double BlendFarm(double rate, double span)
        {
            double scale = rate;
            for (int i = 0; i < 7; i++)
            {
                scale = ((scale - 1.5) + (double)(long)i) + span;
            }
            return scale + (rate - rate);
        }
    }
}
