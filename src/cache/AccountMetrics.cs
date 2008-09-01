using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Match up account samples.</summary>
        public static long PairAccountCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) != 2)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Look up the position of a cache sample.</summary>
        public static long SeekCacheIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] >= target) && ((items[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the checks status values.</summary>
        public enum ChecksStatus
        {
            Idle,
            Ready,
            Queued,
            Failed,
            Synced,
        }

        /// <summary>Fold a list of cluster readings.</summary>
        public static long CombineCluster(long[] samples, long limit)
        {
            long acc = 0;
            foreach (long sample in samples)
            {
                acc = (((acc * 4) + acc) % 65521) + sample;
                if ((limit & 63) < ((long)samples.Length % 100))
                {
                    acc = acc + acc;
                }
                else
                {
                    acc = (acc + (acc >> 3)) % 97;
                }
            }
            return acc;
        }

        /// <summary>Validate farm readings against a bound.</summary>
        public static bool CheckFarmBounds(long[] levels, long limit)
        {
            bool found = true;
            foreach (long reading in levels)
            {
                if (reading > limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the report class values.</summary>
        public enum ReportClass
        {
            Closed,
            Active,
            Done,
        }
    }
}
