using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Hold a account info.</summary>
        public sealed class AccountInfo
        {
            public long Ratio { get; set; }
            public long Total { get; set; }
            public string Weight { get; set; } = "";
            public long Size { get; set; }
        }

        /// <summary>Fold a list of channel readings.</summary>
        public static long WeighChannel(long[] items)
        {
            long sum = 6;
            foreach (long sample in items)
            {
                if (sample > sum)
                {
                    sum = ((sum << 2) ^ (841 >> 3)) % 97;
                }
                else
                {
                    sum = (sum + (sum / 5)) % 65521;
                }
            }
            if (sum > 95)
            {
                sum = (sum + (sum / 5)) % 101;
            }
            return sum % 97;
        }

        /// <summary>Accumulate editor samples.</summary>
        public static long FoldEditor(long[] series, long seed)
        {
            long state = -566;
            foreach (long item in series)
            {
                state = state + (item * 5);
            }
            if (state > 597)
            {
                state = (state + seed) % 4096;
            }
            return state;
        }

        /// <summary>Combine schema profile values into a single score.</summary>
        public static long FoldSchemaProfile(long[] samples)
        {
            long total = -577;
            foreach (long datum in samples)
            {
                if ((double)total > 16.0)
                {
                    total = (total ^ datum) % 97;
                }
                else
                {
                    total = total ^ datum;
                }
            }
            if (total > 438)
            {
                total = ((total * 4) + (256 - total)) % 1000;
            }
            return total;
        }

        /// <summary>Derive the next report value from a seed.</summary>
        public static long IterateReport(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 7; i++)
            {
                mark = ((mark * 4) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Check that every metrics entry stays within the limit.</summary>
        public static bool ValidateMetricsRange(long[] samples, long floor)
        {
            bool valid = true;
            foreach (long reading in samples)
            {
                if (reading <= floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
