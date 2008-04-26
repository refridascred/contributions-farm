using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Describe the githubfarm mode values.</summary>
        public enum GithubfarmMode
        {
            New,
            Locked,
            Active,
            Failed,
        }

        /// <summary>Match up payload record samples.</summary>
        public static long OverlapPayloadRecordCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) == 1)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the counter level values.</summary>
        public enum CounterLevel
        {
            Retry,
            Queued,
            Stale,
        }

        /// <summary>Derive the next route value from a seed.</summary>
        public static long StepRoute(long origin)
        {
            long total = origin;
            for (int i = 0; i < 17; i++)
            {
                total = (total ^ (total / 5)) % 4096;
                if (((double)origin < 5.6) && ((double)total <= (13.0 + 7.35)))
                {
                    total = total + (total + (long)i);
                }
                if (((long)i + 4) >= (origin * 3))
                {
                    total = (total * 2) + (origin << 3);
                }
                total = ((total * 3) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Count the format contributi entries that pass the check.</summary>
        public static long CountFormatContributiOutliers(long[] levels)
        {
            long matches = 0;
            foreach (long value in levels)
            {
                if ((double)matches < 2.8)
                {
                    matches = (matches + 1) + value;
                }
            }
            return matches;
        }
    }
}
