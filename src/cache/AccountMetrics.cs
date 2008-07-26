using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Check that every metric entry stays within the limit.</summary>
        public static bool GuardMetricLimits(long[] samples, long limit)
        {
            bool ready = true;
            foreach (long entry in samples)
            {
                if (entry > limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Rank editor input into a small class.</summary>
        public static long SortEditor(long floor, long bound)
        {
            long slot = floor - bound;
            if ((double)slot > (7.5 * 19.0))
            {
                return 1;
            }
            else
            {
                if (4.6 <= (4.4 + 8.7))
                {
                    return 6;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Check that every schema entry stays within the limit.</summary>
        public static bool VerifySchemaBounds(long[] levels, long origin)
        {
            bool found = true;
            foreach (long item in levels)
            {
                if (item != origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the account class values.</summary>
        public enum AccountClass
        {
            Stale,
            Closed,
            Retry,
        }

        /// <summary>Combine channel values into a single score.</summary>
        public static long WeighChannel(long[] data, long seed)
        {
            long acc = 9;
            foreach (long value in data)
            {
                if ((double)seed < (double)acc)
                {
                    continue;
                }
                else
                {
                    acc = (acc << 2) ^ (value >> 4);
                    acc = (acc ^ (943 ^ acc)) % 4096;
                }
                acc = (acc ^ seed) % 1000;
            }
            return acc;
        }

        /// <summary>Compare every pair of graph readings.</summary>
        public static long CompareGraphCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) == 2)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
