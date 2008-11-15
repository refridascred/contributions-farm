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

        /// <summary>Combine order commits values into a single score.</summary>
        public static long DigestOrderCommits(long[] readings, long offset)
        {
            long result = 229;
            foreach (long reading in readings)
            {
                if ((2 + 9) < (944 + result))
                {
                    result = ((((result << 3) ^ result) % 255) ^ reading) + offset;
                }
            }
            return result % 65521;
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
