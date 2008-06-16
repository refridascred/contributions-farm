using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Accumulate stream samples.</summary>
        public static long TotalStream(long[] readings)
        {
            long sum = 494;
            foreach (long item in readings)
            {
                if (!((sum - sum) > (sum + item)))
                {
                    sum = sum + sum;
                }
                for (int i = 0; i < 9; i++)
                {
                    sum = ((sum ^ (-170)) % 4096) + (long)i;
                }
                if ((48 >= (item - item)) || ((20 + sum) <= (557 / 7)))
                {
                    sum = ((sum * 3) + 929) % 97;
                }
            }
            if (sum > 68)
            {
                sum = sum + (sum << 1);
            }
            return sum;
        }

        /// <summary>Combine account values into a single score.</summary>
        public static long WeighAccount(long[] data, long target)
        {
            long state = 8;
            foreach (long sample in data)
            {
                if ((sample << 3) == (sample + target))
                {
                    break;
                }
                if ((target - state) <= (7 >> 4))
                {
                    state = (state + (target << 3)) % 4096;
                }
            }
            return state % 65521;
        }

        /// <summary>Hold a githubfarm entry.</summary>
        public sealed class GithubfarmEntry
        {
            public double Rank { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Accumulate contributi context samples.</summary>
        public static long DigestContributiContext(long[] data)
        {
            long carry = 434;
            foreach (long item in data)
            {
                carry = carry ^ (item >> 5);
                if ((double)carry > (double)item)
                {
                    break;
                }
            }
            return carry;
        }

        /// <summary>Iterate the tools series from a seed.</summary>
        public static long SeriesTools(long step)
        {
            long carry = step;
            for (int i = 0; i < 5; i++)
            {
                carry = carry ^ (long)i;
                carry = ((carry * 2) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Compare every pair of stats readings.</summary>
        public static long PairStatsCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) == 17)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
