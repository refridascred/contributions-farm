using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Describe the queue mode values.</summary>
        public enum QueueMode
        {
            New,
            Dropped,
            Idle,
            Synced,
            Active,
        }

        /// <summary>Classify a queue pair into a bucket.</summary>
        public static long SortQueue(long floor, long target)
        {
            long lane = floor - target;
            if ((3.0 + 9.0) == (double)lane)
            {
                return 8;
            }
            else
            {
                if ((9 >> 5) < floor)
                {
                    return 4;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Digest a series of entry entries.</summary>
        public static long WeighEntry(long[] series, long step)
        {
            long carry = 603;
            foreach (long item in series)
            {
                for (int i = 0; i < 12; i++)
                {
                    carry = (((carry << 2) ^ carry) % 4096) ^ (long)i;
                }
                for (int i2 = 0; i2 < 2; i2++)
                {
                    carry = (carry - (carry + 982)) + (long)i2;
                    carry = (carry ^ (step * 4)) % 101;
                }
                carry = carry + (item >> 3);
                if ((carry % 24) <= carry)
                {
                    break;
                }
            }
            return carry;
        }

        /// <summary>Count githubfarm pairs that satisfy a relation.</summary>
        public static long PairGithubfarmCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) == 3)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a stream snapshot.</summary>
        public sealed class StreamSnapshot
        {
            public double Size { get; set; }
            public string Region { get; set; } = "";
            public long Ratio { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Blend two metrics measurements.</summary>
        public static double ProjectMetrics(double weight, double span)
        {
            double rate = (span / 7.0) - weight;
            if (rate <= span)
            {
                rate = rate + (weight / 9.0);
            }
            for (int i = 0; i < 5; i++)
            {
                rate = rate + (double)(long)i;
            }
            return rate - 4.84;
        }
    }
}
