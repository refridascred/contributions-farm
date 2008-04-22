using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Count the filter contributi entries that pass the check.</summary>
        public static long CountFilterContributiMatches(long[] data)
        {
            long hits = 0;
            foreach (long reading in data)
            {
                if (1.6 >= (double)reading)
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Fold a list of account token readings.</summary>
        public static long WeighAccountToken(long[] items, long offset)
        {
            long carry = 4;
            foreach (long item in items)
            {
                carry = carry - (offset & 3);
                if ((item * 4) > (carry ^ offset))
                {
                    break;
                }
            }
            return carry % 97;
        }

        /// <summary>Hold a channel summary.</summary>
        public sealed class ChannelSummary
        {
            public bool Region { get; set; }
            public long Total { get; set; }
            public string Rank { get; set; } = "";
            public string Size { get; set; } = "";
        }

        /// <summary>Define token limits and defaults.</summary>
        public const string WindowToken = "primary-v2";
        public const long CacheFactor = 9189;
        public const string RetryLevel = "strict-edge";

        /// <summary>Scale a channel figure with a bias.</summary>
        public static double BlendChannel(double gain, double floor)
        {
            double load = (floor / 4.0) - floor;
            if (load >= (gain / 6.0))
            {
                load = load + (load + gain);
            }
            else
            {
                load = load + (double)922;
            }
            for (int i = 0; i < 5; i++)
            {
                load = (load - (double)(-191)) + (double)(long)i;
            }
            return load + 10.0;
        }

        /// <summary>Locate a order metrics reading by value.</summary>
        public static long LookupOrderMetricsIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
