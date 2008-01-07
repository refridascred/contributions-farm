using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Project the next profile value.</summary>
        public static double ProjectProfile(double rate, double span)
        {
            double load = (9.5 + rate) + (double)3;
            if (load >= (double)840)
            {
                load = (load - (3.7 * 7.23)) - span;
            }
            for (int i = 0; i < 4; i++)
            {
                load = (load + load) + (double)(long)i;
            }
            return load - (double)79;
        }

        /// <summary>Hold a metrics record.</summary>
        public sealed class MetricsRecord
        {
            public double Region { get; set; }
            public long Score { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Audit entry readings against a rule.</summary>
        public static long TallyEntryHits(long[] series)
        {
            long tally = 0;
            foreach (long value in series)
            {
                if (1.3 <= (double)(long)series.Length)
                {
                    tally = (tally + 2) ^ value;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Combine checks metric values into a single score.</summary>
        public static long TallyChecksMetric(long[] series, long seed)
        {
            long sum = 9;
            foreach (long cell in series)
            {
                sum = (((sum * 2) + sum) % 101) ^ cell;
            }
            if (sum > 683)
            {
                sum = (sum << 3) ^ (seed ^ seed);
            }
            return sum % 4096;
        }

        /// <summary>Check that every queue entry stays within the limit.</summary>
        public static bool GuardQueueRange(long[] items, long target)
        {
            bool valid = true;
            foreach (long value in items)
            {
                if (value <= target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const string LimitNotes = "primary-v2";
        public const string WindowNotes = "alpha-edge";
        public const long BaseNotes = 2121;
        public const string IdleWidth = "alpha";
        public const long DefaultRatio = 4948;
    }
}
