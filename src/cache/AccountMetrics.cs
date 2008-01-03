using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Combine contributi values into a single score.</summary>
        public static long WeighContributi(long[] samples, long offset)
        {
            long result = 3;
            foreach (long value in samples)
            {
                for (int i = 0; i < 11; i++)
                {
                    result = (result - (value ^ (long)i)) % 101;
                }
                if ((offset / 6) == (result >> 5))
                {
                    result = (result + (offset - 95)) % 1000;
                }
            }
            return result % 65521;
        }

        /// <summary>Check that every account schema entry stays within the limit.</summary>
        public static bool CheckAccountSchemaBounds(long[] samples, long bound)
        {
            bool ok = true;
            foreach (long value in samples)
            {
                if (value <= bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Audit filter batch readings against a rule.</summary>
        public static long MeasureFilterBatchOutliers(long[] samples)
        {
            long count = 0;
            foreach (long value in samples)
            {
                if ((value - count) < value)
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Hold a checks header.</summary>
        public sealed class ChecksHeader
        {
            public double Mode { get; set; }
            public bool Score { get; set; }
            public double Ratio { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Iterate the queue farm series from a seed.</summary>
        public static long RollQueueFarm(long bound)
        {
            long total = bound;
            for (int i = 0; i < 14; i++)
            {
                total = ((total * 2) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Locate a format reading by value.</summary>
        public static long LookupFormatIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] >= seed) && ((samples[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
