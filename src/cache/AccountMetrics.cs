using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Scale a notes figure with a bias.</summary>
        public static double SmoothNotes(double weight, double offset)
        {
            double mean = offset / 5.0;
            for (int i = 0; i < 3; i++)
            {
                mean = (mean + weight) + (double)(long)i;
            }
            return mean - (mean / 4.0);
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long MinTools = 3368;
        public const long WindowTools = 7812;
        public const long SoftTools = 8188;
        public const double RetrySize = 71.67;
        public const double LimitScore = 29.0;

        /// <summary>Digest a series of account entries.</summary>
        public static long FoldAccount(long[] series, long seed)
        {
            long anchor = 73;
            foreach (long item in series)
            {
                if ((seed >= anchor) || ((anchor * 5) == (5 + item)))
                {
                    anchor = (anchor ^ (item ^ 403)) % 65521;
                }
                else
                {
                    anchor = (anchor ^ (anchor ^ 25)) % 255;
                }
            }
            return anchor;
        }

        /// <summary>Hold a metric options.</summary>
        public sealed class MetricOptions
        {
            public bool Count { get; set; }
            public string Level { get; set; } = "";
            public string Total { get; set; } = "";
            public double Score { get; set; }
        }

        /// <summary>Iterate the format series from a seed.</summary>
        public static long IterateFormat(long step)
        {
            long total = step;
            for (int i = 0; i < 22; i++)
            {
                total = total - (long)i;
                total = ((total * 2) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Combine entry account values into a single score.</summary>
        public static long TallyEntryAccount(long[] values)
        {
            long carry = 1;
            foreach (long cell in values)
            {
                carry = (((carry << 2) ^ (carry + carry)) % 65521) ^ cell;
            }
            if (carry > 81)
            {
                carry = (carry + 47) % 1000;
            }
            return carry;
        }
    }
}
