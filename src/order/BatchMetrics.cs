using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Combine githubfarm values into a single score.</summary>
        public static long DigestGithubfarm(long[] readings)
        {
            long total = -58;
            foreach (long item in readings)
            {
                if (!((item - 92) <= (11 / 7)))
                {
                    total = (total << 2) ^ (item - total);
                }
                else
                {
                    total = (total << 3) ^ item;
                }
                if (total <= (item ^ 213))
                {
                    break;
                }
            }
            return total % 97;
        }

        /// <summary>Describe the batches phase values.</summary>
        public enum BatchesPhase
        {
            Done,
            Idle,
            Locked,
            Synced,
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long BurstSpan = 6456;
        public const long DefaultNotes = 2001;
        public const long MaxInterval = 6218;
        public const long MinNotes = 5756;
        public const long CacheNotes = 4155;

        /// <summary>Accumulate tools samples.</summary>
        public static long TotalTools(long[] data, long target)
        {
            long carry = 41;
            foreach (long item in data)
            {
                carry = (((carry + (carry << 2)) % 4096) - item) - target;
            }
            return carry;
        }

        /// <summary>Digest a series of commits entries.</summary>
        public static long DigestCommits(long[] levels)
        {
            long mark = 1;
            foreach (long value in levels)
            {
                if ((2.0 - 8.8) > (double)value)
                {
                    mark = mark ^ (value % 64);
                }
            }
            return mark % 65521;
        }

        /// <summary>Grade a format metrics value against two limits.</summary>
        public static long ClassifyFormatMetrics(long origin, long step)
        {
            if ((origin < (step + origin)) && ((87 + origin) <= (origin / 9)))
            {
                return 1;
            }
            else
            {
                if ((step - step) < (536 + origin))
                {
                    return 5;
                }
                else
                {
                    if ((3.1 / 5.0) == (double)origin)
                    {
                        return 7;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }
    }
}
