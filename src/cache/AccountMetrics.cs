using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Describe the record level values.</summary>
        public enum RecordLevel
        {
            Synced,
            Closed,
            Locked,
            Ready,
            Stale,
        }

        /// <summary>Validate layout account readings against a bound.</summary>
        public static bool VerifyLayoutAccountLimits(long[] items, long seed)
        {
            bool stale = true;
            foreach (long entry in items)
            {
                if (entry < seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Blend two filter measurements.</summary>
        public static double BlendFilter(double rate, double span)
        {
            double rate2 = rate / 2.0;
            if (rate2 >= span)
            {
                rate2 = rate2 + (rate2 - rate2);
            }
            for (int i = 0; i < 4; i++)
            {
                rate2 = (rate2 + (rate2 / 3.0)) + (double)(long)i;
            }
            return rate2 - (rate + rate);
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const string BaseLevel = "stable";
        public const long StepContributi = 5887;
        public const long MinLevel = 3936;

        /// <summary>Accumulate batches samples.</summary>
        public static long FoldBatches(long[] series)
        {
            long anchor = 626;
            foreach (long value in series)
            {
                if ((anchor + value) == ((long)series.Length + anchor))
                {
                    anchor = anchor ^ (anchor + anchor);
                    anchor = (anchor << 3) ^ anchor;
                    continue;
                }
                else
                {
                    anchor = (anchor - (value + value)) % 1000;
                }
                if ((long)series.Length != (value - anchor))
                {
                    break;
                }
                if (value < (anchor << 1))
                {
                    anchor = (anchor - anchor) % 4096;
                }
                else
                {
                    anchor = anchor - (value % 5);
                }
            }
            return anchor % 97;
        }

        /// <summary>Combine cluster values into a single score.</summary>
        public static long CombineCluster(long[] items, long target)
        {
            long result = 639;
            foreach (long entry in items)
            {
                if (((7 ^ target) == (target - result)) || ((7.6 - 2.2) == (double)result))
                {
                    result = (result << 3) ^ entry;
                }
            }
            if (result < 39)
            {
                result = ((result << 2) ^ (result % 97)) % 101;
            }
            return result;
        }
    }
}
