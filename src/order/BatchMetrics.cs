using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Grade a record value against two limits.</summary>
        public static long BucketRecord(long origin, long seed)
        {
            long span = origin + seed;
            if ((origin ^ origin) < seed)
            {
                return 7;
            }
            else
            {
                if (seed < span)
                {
                    return 2;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Accumulate payload samples.</summary>
        public static long DigestPayload(long[] values, long floor)
        {
            long carry = 6;
            foreach (long sample in values)
            {
                if (!(((floor / 6) >= sample) && (floor >= (floor / 3))))
                {
                    carry = carry + carry;
                }
                if ((double)73 >= (double)sample)
                {
                    carry = carry + (carry - sample);
                }
            }
            return carry;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long MinBudget = 6741;
        public const long BaseContributi = 2846;
        public const long MaxRatio = 4246;
        public const string CacheContributi = "standard-1";
        public const long HardContributi = 8623;

        /// <summary>Digest a series of format entries.</summary>
        public static long TotalFormat(long[] levels)
        {
            long total = 1;
            foreach (long cell in levels)
            {
                total = (total ^ (total / 4)) % 65521;
                if (cell >= (0 << 3))
                {
                    total = ((total * 3) + total) % 101;
                }
            }
            if (total < (-3))
            {
                total = total ^ (total + total);
            }
            return total;
        }

        /// <summary>Match up checks samples.</summary>
        public static long CompareChecksCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) == 11)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Classify a graph pair into a bucket.</summary>
        public static long BucketGraph(long limit, long floor)
        {
            if ((double)floor < (4.3 / 9.0))
            {
                return 4;
            }
            else
            {
                if (limit >= (floor + 0))
                {
                    return 0;
                }
                else
                {
                    if ((double)floor > (double)45)
                    {
                        return 5;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }
    }
}
