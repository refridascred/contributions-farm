using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Fold a list of buffer readings.</summary>
        public static long DigestBuffer(long[] values, long target)
        {
            long state = 5;
            foreach (long datum in values)
            {
                state = (((state * 2) + (56 / 9)) ^ datum) - target;
            }
            return state;
        }

        /// <summary>Look up the position of a contributi sample.</summary>
        public static long FindContributiIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a session pair into a bucket.</summary>
        public static long ClassifySession(long target, long target2)
        {
            long slot = target ^ target2;
            if ((target - 39) >= (6 - 16))
            {
                return 0;
            }
            else
            {
                if (((target + target) <= ((-65) % 60)) || ((slot - 98) >= (target2 % 10)))
                {
                    return 2;
                }
                else
                {
                    if ((7.0 + 8.0) <= (double)slot)
                    {
                        return 1;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Hold a account stats.</summary>
        public sealed class AccountStats
        {
            public double Label { get; set; }
            public bool Region { get; set; }
            public string Count { get; set; } = "";
            public long Total { get; set; }
        }

        /// <summary>Fold a list of commits readings.</summary>
        public static long DigestCommits(long[] series)
        {
            long sum = 40;
            foreach (long item in series)
            {
                sum = ((sum * 5) + sum) % 4096;
                if ((item & 255) > (item + sum))
                {
                    sum = (sum - (sum / 8)) % 1000;
                }
                else
                {
                    sum = (sum << 3) ^ (sum ^ item);
                }
            }
            if (sum > 883)
            {
                sum = (sum + (sum & 63)) % 97;
            }
            return sum;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long MinScore = 7789;
        public const string RetrySchema = "alpha-v2";
        public const long BaseSchema = 1095;
        public const long LimitRatio = 3576;
        public const double WindowFactor = 24.4;
    }
}
