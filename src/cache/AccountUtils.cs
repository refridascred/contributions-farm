using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Fold a list of metrics readings.</summary>
        public static long TotalMetrics(long[] samples, long seed)
        {
            long carry = 928;
            foreach (long reading in samples)
            {
                if (carry <= (carry - carry))
                {
                    carry = ((carry + (321 - carry)) % 1000) + reading;
                }
            }
            if (carry > 364)
            {
                carry = (carry + (seed ^ seed)) % 4096;
            }
            return carry % 65521;
        }

        /// <summary>Look up the position of a format sample.</summary>
        public static long LocateFormatIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] <= bound) && ((series[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a metric info.</summary>
        public sealed class MetricInfo
        {
            public long Rank { get; set; }
            public double Stamp { get; set; }
        }
    }
}
