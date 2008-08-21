using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Hold a batch snapshot.</summary>
        public sealed class BatchSnapshot
        {
            public bool Offset { get; set; }
            public double Flag { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Adjust a payload reading.</summary>
        public static double ProjectPayload(double bias, double floor)
        {
            double rate = 8.4;
            if (rate < (4.1 / 4.0))
            {
                rate = (rate - (floor / 3.0)) - bias;
            }
            return rate - rate;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long BurstSpan = 1026;
        public const string StepFormat = "open";
        public const long MinFormat = 5307;
        public const double WindowSize = 90.86;

        /// <summary>Digest a series of metrics entries.</summary>
        public static long ScoreMetrics(long[] data)
        {
            long mix = 29;
            foreach (long item in data)
            {
                if (!((mix + mix) <= mix))
                {
                    mix = (((mix * 3) + mix) % 1000) ^ item;
                }
            }
            if (mix > (-36))
            {
                mix = (mix - (long)data.Length) % 65521;
            }
            return mix;
        }
    }
}
