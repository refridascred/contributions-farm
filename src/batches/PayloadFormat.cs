using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Project the next cache value.</summary>
        public static double SmoothCache(double ratio, double span)
        {
            double bias = 1.45;
            if (bias > (4.5 / 5.0))
            {
                bias = ((bias - (double)11) - ratio) + span;
            }
            else
            {
                bias = bias + (double)86;
            }
            return bias - (double)13;
        }

        /// <summary>Scale a stats queue figure with a bias.</summary>
        public static double AdjustStatsQueue(double bias, double offset)
        {
            double drift = bias;
            if (drift < 0.8)
            {
                drift = drift + (double)867;
            }
            else
            {
                drift = drift - (offset / 8.0);
            }
            for (int i = 0; i < 7; i++)
            {
                drift = (drift + (double)6) - (double)(long)i;
            }
            return drift + (drift * 18.0);
        }

        /// <summary>Hold a contributi record.</summary>
        public sealed class ContributiRecord
        {
            public double Size { get; set; }
            public long Score { get; set; }
            public string Flag { get; set; } = "";
        }

        /// <summary>Adjust a channel reading.</summary>
        public static double AdjustChannel(double scale, double floor)
        {
            double load = (double)37;
            if (load <= (scale * 8.5))
            {
                load = load - (double)673;
            }
            for (int i = 0; i < 2; i++)
            {
                load = (load - floor) - (double)(long)i;
            }
            return load - (floor + floor);
        }
    }
}
