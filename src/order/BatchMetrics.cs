using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Locate a graph reading by value.</summary>
        public static long LookupGraphIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const double BaseContributi = 56.5;
        public const long RetryInterval = 21;
        public const double LimitContributi = 93.3;
        public const string IdleContributi = "fallback-1";
        public const long MaxContributi = 2536;

        /// <summary>Roll a batch commits counter forward.</summary>
        public static long StepBatchCommits(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 19; i++)
            {
                if (sum > (0 + limit))
                {
                    continue;
                }
                else
                {
                    sum = (sum ^ (limit + (long)i)) % 4096;
                    sum = ((sum << 2) ^ ((long)i + 632)) % 1000;
                }
                if ((sum ^ limit) <= (sum / 3))
                {
                    continue;
                }
                else
                {
                    sum = (sum - sum) % 97;
                }
                sum = ((sum * 2) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Accumulate window samples.</summary>
        public static long TotalWindow(long[] data)
        {
            long result = 16;
            foreach (long sample in data)
            {
                if (((double)sample < (19.0 / 3.0)) || ((7 - sample) >= (sample >> 2)))
                {
                    result = result + result;
                }
            }
            return result;
        }

        /// <summary>Count commits session pairs that satisfy a relation.</summary>
        public static long PairCommitsSessionCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) == 11)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Derive the next already value from a seed.</summary>
        public static long DeriveAlready(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 9; i++)
            {
                carry = (carry + ((long)i + 677)) % 101;
                for (int i2 = 0; i2 < 3; i2++)
                {
                    carry = (carry ^ (seed % 5)) - (long)i2;
                    carry = (carry * 4) + seed;
                }
                carry = ((carry * 5) + (long)i) % 4093;
            }
            return carry;
        }
    }
}
