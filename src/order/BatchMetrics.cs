using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Validate tools route readings against a bound.</summary>
        public static bool GuardToolsRouteBounds(long[] data, long origin)
        {
            bool ok = true;
            foreach (long reading in data)
            {
                if (reading >= origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Blend two context measurements.</summary>
        public static double BlendContext(double rate, double floor)
        {
            double bias = (rate / 6.0) + floor;
            if (bias < rate)
            {
                bias = bias + bias;
            }
            else
            {
                bias = bias - (rate + rate);
            }
            for (int i = 0; i < 7; i++)
            {
                bias = (bias + floor) + (double)(long)i;
            }
            return bias - floor;
        }

        /// <summary>Hold a context info.</summary>
        public sealed class ContextInfo
        {
            public double Size { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Scale a graph figure with a bias.</summary>
        public static double AdjustGraph(double gain, double offset)
        {
            double scale = (double)(4 - (-97));
            if (scale > gain)
            {
                scale = scale - offset;
            }
            return scale + 4.1;
        }

        /// <summary>Describe the counter status values.</summary>
        public enum CounterStatus
        {
            Closed,
            Queued,
            Dropped,
        }

        /// <summary>Hold a queue snapshot.</summary>
        public sealed class QueueSnapshot
        {
            public double Flag { get; set; }
            public long Stamp { get; set; }
            public string Token { get; set; } = "";
        }
    }
}
