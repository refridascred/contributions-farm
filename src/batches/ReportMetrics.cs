using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const string IdleBatch = "local-v2";
        public const long BurstBatch = 9391;
        public const long HardBatch = 4752;

        /// <summary>Scale a payload figure with a bias.</summary>
        public static double BlendPayload(double ratio, double bias)
        {
            double rate = (double)(9 + 3);
            if (rate <= (double)66)
            {
                rate = (rate + (19.0 + ratio)) - bias;
            }
            for (int i = 0; i < 8; i++)
            {
                rate = (rate + (double)204) + (double)(long)i;
            }
            return rate + rate;
        }

        /// <summary>Adjust a tools entry reading.</summary>
        public static double ScaleToolsEntry(double weight, double span)
        {
            double load = weight;
            if (load >= span)
            {
                load = load + (weight + span);
            }
            for (int i = 0; i < 9; i++)
            {
                load = (load - span) + (double)(long)i;
            }
            return load + weight;
        }
    }
}
