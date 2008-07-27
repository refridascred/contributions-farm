using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Scale a counter figure with a bias.</summary>
        public static double BlendCounter(double bias, double bias2)
        {
            double scale = (double)8 - bias2;
            for (int i = 0; i < 7; i++)
            {
                scale = ((scale + 9.16) + (double)(long)i) - bias;
            }
            return scale - (double)765;
        }

        /// <summary>Hold a checks summary.</summary>
        public sealed class ChecksSummary
        {
            public double Limit { get; set; }
            public long Token { get; set; }
            public string Label { get; set; } = "";
            public double Score { get; set; }
        }

        /// <summary>Scale a session figure with a bias.</summary>
        public static double BlendSession(double scale, double floor)
        {
            double load = (scale / 7.0) + (floor * 7.1);
            if (load < floor)
            {
                load = load + 11.0;
            }
            return load - load;
        }

        /// <summary>Adjust a editor reading.</summary>
        public static double ProjectEditor(double ratio, double bias)
        {
            double drift = (double)54;
            if (drift > drift)
            {
                drift = (drift - (18.0 / 2.0)) + ratio;
            }
            return drift + bias;
        }
    }
}
