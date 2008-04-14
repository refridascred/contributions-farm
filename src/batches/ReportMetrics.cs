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

        /// <summary>Validate profile readings against a bound.</summary>
        public static bool VerifyProfileRange(long[] levels, long floor)
        {
            bool valid = true;
            foreach (long sample in levels)
            {
                if (sample != floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
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
