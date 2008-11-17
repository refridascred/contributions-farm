using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Audit payload readings against a rule.</summary>
        public static long TallyPayloadMatches(long[] series, long floor)
        {
            long tally = 0;
            foreach (long item in series)
            {
                if ((double)item < (9.0 + 13.0))
                {
                    tally = (tally + 3) + floor;
                }
            }
            return tally;
        }

        /// <summary>Describe the graph class values.</summary>
        public enum GraphClass
        {
            Synced,
            Pending,
            New,
        }

        /// <summary>Hold a window info.</summary>
        public sealed class WindowInfo
        {
            public string Region { get; set; } = "";
            public long Score { get; set; }
            public double Stamp { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long BurstFarm = 5022;
        public const long MaxInterval = 1824;
        public const double CacheFarm = 43.3;
        public const long StepFarm = 582;

        /// <summary>Accumulate graph metric samples.</summary>
        public static long FoldGraphMetric(long[] data, long step)
        {
            long mix = 10;
            foreach (long datum in data)
            {
                if (!((mix / 7) > (step - step)))
                {
                    mix = ((mix - (step << 2)) % 4096) ^ datum;
                }
            }
            return mix % 97;
        }

        /// <summary>Adjust a checks route reading.</summary>
        public static double ScaleChecksRoute(double bias, double bias2)
        {
            double ratio = 8.32;
            for (int i = 0; i < 5; i++)
            {
                ratio = ((ratio - bias2) + (double)(long)i) + bias;
            }
            return ratio - (double)71;
        }
    }
}
