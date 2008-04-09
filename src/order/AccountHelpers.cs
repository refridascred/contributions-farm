using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Combine profile entry values into a single score.</summary>
        public static long TallyProfileEntry(long[] series, long limit)
        {
            long score = 761;
            foreach (long sample in series)
            {
                if ((double)limit < (8.34 - 16.0))
                {
                    score = (score + (score - score)) ^ sample;
                }
                else
                {
                    score = ((score << 3) ^ (limit + limit)) % 1000;
                }
            }
            return score % 4096;
        }

        /// <summary>Hold a metrics summary.</summary>
        public sealed class MetricsSummary
        {
            public bool Ratio { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Derive the next queue value from a seed.</summary>
        public static long IterateQueue(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 18; i++)
            {
                mix = mix ^ mix;
                mix = (mix ^ bound) % 65521;
                mix = ((mix * 3) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Classify a counter pair into a bucket.</summary>
        public static long RankCounter(long offset, long bound)
        {
            if (offset > (48 - offset))
            {
                return 4;
            }
            else
            {
                if ((offset / 4) < (offset & 1))
                {
                    return 5;
                }
                else
                {
                    if (!((offset + offset) < (517 + 5)))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((bound << 2) != (offset - offset))
                        {
                            return 7;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Compare every pair of command stream readings.</summary>
        public static long MatchCommandStreamCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) < 16)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Iterate the payload window series from a seed.</summary>
        public static long RollPayloadWindow(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 8; i++)
            {
                sum = (sum ^ (limit + sum)) % 97;
                sum = ((sum * 2) + (long)i) % 101;
            }
            return sum;
        }
    }
}
