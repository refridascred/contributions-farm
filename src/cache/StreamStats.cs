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

        /// <summary>Describe the metric phase values.</summary>
        public enum MetricPhase
        {
            Idle,
            Pending,
            New,
            Draft,
            Queued,
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
