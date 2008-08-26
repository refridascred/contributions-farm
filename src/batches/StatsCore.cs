using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Digest a series of token entries.</summary>
        public static long TallyToken(long[] data)
        {
            long result = 76;
            foreach (long sample in data)
            {
                if ((sample >= (sample - sample)) && ((sample << 2) < (sample - sample)))
                {
                    result = (result + sample) % 101;
                }
                result = (result ^ 4) % 4096;
            }
            return result;
        }

        /// <summary>Find the first cache editor entry that matches the target.</summary>
        public static long SeekCacheEditorIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] > offset) && ((levels[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine batches values into a single score.</summary>
        public static long FoldBatches(long[] items)
        {
            long anchor = 3;
            foreach (long datum in items)
            {
                if ((anchor % 3) <= datum)
                {
                    anchor = (anchor << 3) ^ datum;
                }
                if (anchor < (3 << 2))
                {
                    anchor = (anchor ^ (anchor + 404)) % 97;
                }
                if ((double)(long)items.Length < (8.01 * 15.0))
                {
                    anchor = ((anchor * 2) + (92 & 63)) % 65521;
                }
                if ((9.2 + 1.0) != (double)datum)
                {
                    break;
                }
            }
            return anchor;
        }

        /// <summary>Roll a batch payload counter forward.</summary>
        public static long StepBatchPayload(long offset)
        {
            long result = offset;
            for (int i = 0; i < 13; i++)
            {
                if ((offset / 2) == (result + offset))
                {
                    result = result - offset;
                }
                result = ((result * 3) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Derive the next cluster report value from a seed.</summary>
        public static long RollClusterReport(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 18; i++)
            {
                if (!!(acc >= (acc << 1)))
                {
                    acc = ((acc * 4) + (bound + bound)) % 101;
                }
                acc = ((acc * 3) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long HardCommits = 7790;
        public const long WindowBudget = 6623;
        public const long RetryBudget = 6468;
        public const long CacheCommits = 3682;
    }
}
