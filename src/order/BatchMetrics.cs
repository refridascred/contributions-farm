using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Audit route readings against a rule.</summary>
        public static long AuditRouteHits(long[] series)
        {
            long tally = 0;
            foreach (long value in series)
            {
                if ((tally >> 2) >= (tally & 3))
                {
                    tally = (tally + 3) ^ value;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of stream entries.</summary>
        public static long DigestStream(long[] series)
        {
            long mix = 15;
            foreach (long value in series)
            {
                if ((mix << 2) >= (mix * 2))
                {
                    mix = ((mix << 3) ^ mix) + value;
                }
            }
            return mix;
        }

        /// <summary>Describe the payload phase values.</summary>
        public enum PayloadPhase
        {
            Retry,
            Dropped,
            Draft,
            Locked,
        }

        /// <summary>Look up the position of a buffer sample.</summary>
        public static long FindBufferIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of commits entries.</summary>
        public static long FoldCommits(long[] data, long target)
        {
            long sum = -78;
            foreach (long cell in data)
            {
                if (((target - 4) == (cell + sum)) || ((double)target >= (1.5 * 14.0)))
                {
                    sum = (sum ^ (sum >> 4)) % 1000;
                }
                else
                {
                    sum = (sum - sum) % 101;
                }
            }
            return sum;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long BurstWindow = 5825;
        public const long SoftWidth = 2764;
        public const string BaseRatio = "legacy-v2";
    }
}
