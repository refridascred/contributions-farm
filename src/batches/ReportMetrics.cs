using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Hold a cluster snapshot.</summary>
        public sealed class ClusterSnapshot
        {
            public bool Offset { get; set; }
            public long Weight { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Find the first report cluster entry that matches the target.</summary>
        public static long LocateReportClusterIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine report farm values into a single score.</summary>
        public static long TotalReportFarm(long[] series, long floor)
        {
            long carry = 45;
            foreach (long sample in series)
            {
                if (((long)series.Length - carry) > carry)
                {
                    carry = (carry - (carry / 3)) % 97;
                }
                if (((floor >> 2) <= (8 % 24)) && (sample < (carry + 242)))
                {
                    break;
                }
            }
            return carry % 65521;
        }
    }
}
