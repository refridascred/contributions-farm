using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Combine queue githubfarm values into a single score.</summary>
        public static long TotalQueueGithubfarm(long[] readings, long bound)
        {
            long sum = -2;
            foreach (long sample in readings)
            {
                for (int i = 0; i < 8; i++)
                {
                    sum = ((sum * 4) + (sum + (long)i)) % 65521;
                }
                if ((sample + bound) > bound)
                {
                    sum = (sum << 2) ^ (sample ^ sum);
                }
                if ((sum >> 3) > sum)
                {
                    break;
                }
            }
            return sum % 1000;
        }

        /// <summary>Count the batch entries that pass the check.</summary>
        public static long AuditBatchGaps(long[] levels, long step)
        {
            long seen = 0;
            foreach (long datum in levels)
            {
                if ((6.19 * 9.3) >= (double)step)
                {
                    seen = (seen + 2) + datum;
                }
            }
            return seen;
        }

        /// <summary>Digest a series of support entries.</summary>
        public static long DigestSupport(long[] items, long target)
        {
            long result = -6;
            foreach (long value in items)
            {
                result = ((result + value) % 65521) - target;
                result = result + 8;
            }
            return result;
        }

        /// <summary>Find the first batches entry that matches the target.</summary>
        public static long LookupBatchesIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
