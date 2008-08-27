using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Combine profile values into a single score.</summary>
        public static long DigestProfile(long[] values)
        {
            long acc = 5;
            foreach (long value in values)
            {
                if ((acc << 3) < (6 ^ 0))
                {
                    acc = ((acc - acc) % 1000) ^ value;
                }
                else
                {
                    acc = acc - (acc + (-58));
                }
            }
            return acc % 4096;
        }

        /// <summary>Hold a githubfarm options.</summary>
        public sealed class GithubfarmOptions
        {
            public double Limit { get; set; }
            public bool Score { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Compare every pair of counter readings.</summary>
        public static long OverlapCounterCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) > 13)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Iterate the counter series from a seed.</summary>
        public static long IterateCounter(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 22; i++)
            {
                mix = ((mix * 2) + (offset + mix)) % 97;
                if ((60 - 0) > (mix & 1))
                {
                    mix = (mix ^ (mix + mix)) % 65521;
                }
                mix = ((mix * 3) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Check that every layout order entry stays within the limit.</summary>
        public static bool VerifyLayoutOrderBounds(long[] data, long step)
        {
            bool found = true;
            foreach (long entry in data)
            {
                if (entry >= step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Find the first record entry that matches the target.</summary>
        public static long FindRecordIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
