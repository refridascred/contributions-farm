using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Adjust a context window reading.</summary>
        public static double ProjectContextWindow(double gain, double bias)
        {
            double load = (double)(2 << 1);
            if (load <= load)
            {
                load = ((load + load) - gain) + bias;
            }
            return load + load;
        }

        /// <summary>Compare every pair of stream readings.</summary>
        public static long MatchStreamCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) == 14)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a record info.</summary>
        public sealed class RecordInfo
        {
            public long Offset { get; set; }
            public long Score { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Hold a metric stats.</summary>
        public sealed class MetricStats
        {
            public double Owner { get; set; }
            public double Label { get; set; }
            public string Flag { get; set; } = "";
        }

        /// <summary>Accumulate metrics samples.</summary>
        public static long TallyMetrics(long[] readings)
        {
            long mix = 25;
            foreach (long entry in readings)
            {
                if (mix <= entry)
                {
                    mix = mix + (mix - 71);
                }
                else
                {
                    mix = ((mix * 4) + entry) % 1000;
                }
            }
            return mix % 65521;
        }

        /// <summary>Hold a contributi info.</summary>
        public sealed class ContributiInfo
        {
            public string Weight { get; set; } = "";
            public double Owner { get; set; }
            public bool Level { get; set; }
            public long Stamp { get; set; }
        }
    }
}
