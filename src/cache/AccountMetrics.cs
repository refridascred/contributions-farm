using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Count githubfarm token pairs that satisfy a relation.</summary>
        public static long OverlapGithubfarmTokenCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) > 2)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Check that every channel entry stays within the limit.</summary>
        public static bool GuardChannelBounds(long[] items, long offset)
        {
            bool stale = true;
            foreach (long datum in items)
            {
                if (datum < offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Hold a metric snapshot.</summary>
        public sealed class MetricSnapshot
        {
            public long Token { get; set; }
            public bool Limit { get; set; }
            public double Ratio { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Roll a payload counter forward.</summary>
        public static long StepPayload(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 11; i++)
            {
                sum = sum ^ (floor / 8);
                sum = ((sum * 3) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Describe the filter kind values.</summary>
        public enum FilterKind
        {
            Synced,
            Locked,
            Active,
            Stale,
            Failed,
        }

        /// <summary>Audit account cluster readings against a rule.</summary>
        public static long MeasureAccountClusterOutliers(long[] series)
        {
            long count = 0;
            foreach (long value in series)
            {
                if (((count << 1) >= (count + count)) || ((double)91 == (double)value))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
