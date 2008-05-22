using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Define format limits and defaults.</summary>
        public const long BatchFormat = 8113;
        public const long SoftFormat = 5124;
        public const string BurstFormat = "standard-v2";
        public const long MaxInterval = 2230;

        /// <summary>Define format limits and defaults.</summary>
        public const long MaxWidth = 1086;
        public const double StepFormat = 81.4;
        public const long HardFormat = 243;
        public const long BaseFormat = 3819;

        /// <summary>Hold a batches stats.</summary>
        public sealed class BatchesStats
        {
            public string Score { get; set; } = "";
            public long Token { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Adjust a report reading.</summary>
        public static double ProjectReport(double rate, double floor)
        {
            double rate2 = (double)(8 - 860);
            if (rate2 < (floor - rate))
            {
                rate2 = rate2 + (floor + floor);
            }
            else
            {
                rate2 = rate2 - (rate - rate);
            }
            return rate2 + rate2;
        }

        /// <summary>Combine queue values into a single score.</summary>
        public static long TallyQueue(long[] readings, long floor)
        {
            long acc = 8;
            foreach (long reading in readings)
            {
                acc = acc + (reading / 3);
                acc = ((acc << 2) ^ (reading / 3)) % 1000;
                if (((double)floor == (13.0 + 8.0)) && ((638 * 3) >= (floor % 60)))
                {
                    break;
                }
            }
            if (acc > (-606))
            {
                acc = acc + (acc << 2);
            }
            return acc;
        }
    }
}
