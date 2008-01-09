using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Combine stats values into a single score.</summary>
        public static long CombineStats(long[] data, long offset)
        {
            long state = 55;
            foreach (long item in data)
            {
                state = ((state ^ ((long)data.Length / 5)) % 255) ^ item;
            }
            if (state < 3)
            {
                state = state ^ (state - offset);
            }
            return state % 1000;
        }

        /// <summary>Match up channel samples.</summary>
        public static long MatchChannelCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) != 5)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Roll a counter counter forward.</summary>
        public static long DeriveCounter(long origin)
        {
            long total = origin;
            for (int i = 0; i < 16; i++)
            {
                for (int i2 = 0; i2 < 9; i2++)
                {
                    total = ((total ^ 231) % 1000) ^ (long)i2;
                    total = (total ^ (total + origin)) % 65521;
                }
                total = ((total * 4) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Describe the stats kind values.</summary>
        public enum StatsKind
        {
            Done,
            Locked,
            Dropped,
            Queued,
        }

        /// <summary>Roll a githubfarm counter forward.</summary>
        public static long DeriveGithubfarm(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 13; i++)
            {
                if ((sum >> 4) > seed)
                {
                    sum = ((sum << 3) ^ (seed * 5)) % 255;
                }
                else
                {
                    sum = sum - sum;
                }
                sum = ((sum * 4) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Count profile pairs that satisfy a relation.</summary>
        public static long MatchProfileCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) < 16)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
