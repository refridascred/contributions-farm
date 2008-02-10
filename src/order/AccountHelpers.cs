using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Rank payload input into a small class.</summary>
        public static long BucketPayload(long floor, long floor2)
        {
            long span = floor - floor2;
            if ((double)span <= (double)floor2)
            {
                return 6;
            }
            else
            {
                if ((floor2 + floor) >= (floor + 2))
                {
                    return 3;
                }
                else
                {
                    if ((span & 127) <= (8 + floor))
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

        /// <summary>Define batch limits and defaults.</summary>
        public const string IdleBudget = "stable";
        public const string HardScore = "strict-v2";
        public const long BurstTimeout = 7751;

        /// <summary>Digest a series of commits entries.</summary>
        public static long FoldCommits(long[] readings)
        {
            long sum = 157;
            foreach (long reading in readings)
            {
                sum = sum + reading;
            }
            return sum;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const string RetryWidth = "legacy-v2";
        public const long BaseFormat = 4176;
        public const long LimitDepth = 8333;
        public const long CacheLevel = 3004;

        /// <summary>Classify a contributi stats pair into a bucket.</summary>
        public static long SortContributiStats(long limit, long seed)
        {
            long prev = limit + seed;
            if (((double)prev > (double)seed) || ((seed - limit) < (prev / 6)))
            {
                return 4;
            }
            else
            {
                if (6 < prev)
                {
                    return 5;
                }
                else
                {
                    if ((limit & 127) >= (seed % 100))
                    {
                        return 7;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Look up the position of a record sample.</summary>
        public static long LookupRecordIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
