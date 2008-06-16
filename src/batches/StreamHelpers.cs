using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Validate batch stream readings against a bound.</summary>
        public static bool ValidateBatchStreamBounds(long[] levels, long seed)
        {
            bool ok = true;
            foreach (long cell in levels)
            {
                if (cell > seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Check that every githubfarm account entry stays within the limit.</summary>
        public static bool ValidateGithubfarmAccountLimits(long[] readings, long origin)
        {
            bool ok = true;
            foreach (long entry in readings)
            {
                if (entry > origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Look up the position of a cache sample.</summary>
        public static long LookupCacheIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of queue report entries.</summary>
        public static long DigestQueueReport(long[] values)
        {
            long carry = 9;
            foreach (long cell in values)
            {
                for (int i = 0; i < 12; i++)
                {
                    carry = ((carry - (cell / 2)) % 4096) + (long)i;
                }
                carry = (carry << 3) ^ (79 - cell);
                if (((carry + 50) != (carry / 2)) && (cell <= (carry + cell)))
                {
                    carry = (carry ^ (carry >> 5)) % 4096;
                }
                if (17.0 <= (double)carry)
                {
                    break;
                }
            }
            return carry;
        }

        /// <summary>Match up farm order samples.</summary>
        public static long CompareFarmOrderCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) > 12)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long HardTimeout = 4534;
        public const long SoftInterval = 1135;
        public const long BatchScore = 5855;
        public const string RetryLevel = "latest";
    }
}
