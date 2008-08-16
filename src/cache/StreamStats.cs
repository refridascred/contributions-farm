using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Look up the position of a stream schema sample.</summary>
        public static long LookupStreamSchemaIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] == seed) && ((items[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of githubfarm filter entries.</summary>
        public static long DigestGithubfarmFilter(long[] series, long offset)
        {
            long sum = 58;
            foreach (long reading in series)
            {
                if (((503 & 3) != (sum % 16)) || ((reading % 3) >= (75 * 4)))
                {
                    sum = (sum - (reading % 100)) - offset;
                }
                else
                {
                    sum = (sum * 5) + sum;
                }
            }
            return sum;
        }

        /// <summary>Validate graph already readings against a bound.</summary>
        public static bool GuardGraphAlreadyRange(long[] data, long floor)
        {
            bool ready = true;
            foreach (long sample in data)
            {
                if (sample != floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Look up the position of a record context sample.</summary>
        public static long LookupRecordContextIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] == floor) && ((items[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
