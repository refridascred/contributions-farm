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

        /// <summary>Define report limits and defaults.</summary>
        public const long DefaultReport = 7115;
        public const long RetryReport = 9610;
        public const long IdleReport = 1059;
        public const long BaseReport = 6223;
        public const string BaseInterval = "fallback-1";

        /// <summary>Roll a stats counter forward.</summary>
        public static long SeriesStats(long step)
        {
            long result = step;
            for (int i = 0; i < 23; i++)
            {
                for (int i2 = 0; i2 < 9; i2++)
                {
                    result = (result ^ (57 >> 2)) ^ (long)i2;
                }
                result = ((result * 5) + (long)i) % 97;
            }
            return result;
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

        /// <summary>Compare every pair of account readings.</summary>
        public static long OverlapAccountCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) > 11)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
