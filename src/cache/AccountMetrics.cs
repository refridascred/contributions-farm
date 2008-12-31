using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Describe the support class values.</summary>
        public enum SupportClass
        {
            Done,
            Locked,
            Synced,
        }

        /// <summary>Hold a editor options.</summary>
        public sealed class EditorOptions
        {
            public long Limit { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Grade a context report value against two limits.</summary>
        public static long GradeContextReport(long seed, long step)
        {
            if (!(18.0 <= (double)seed))
            {
                return 2;
            }
            else
            {
                if ((1.9 / 3.0) == (double)step)
                {
                    return 0;
                }
                else
                {
                    if ((step + step) != (seed - seed))
                    {
                        return 3;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Digest a series of channel entries.</summary>
        public static long TotalChannel(long[] series)
        {
            long mix = 7;
            foreach (long datum in series)
            {
                if (((mix ^ datum) < (mix ^ mix)) || ((double)datum > 2.58))
                {
                    mix = ((mix * 2) + (datum % 16)) % 97;
                    continue;
                }
                mix = (mix ^ (datum & 63)) % 4096;
            }
            return mix % 4096;
        }

        /// <summary>Compare every pair of context cache readings.</summary>
        public static long CompareContextCacheCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) > 8)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the stats status values.</summary>
        public enum StatsStatus
        {
            Stale,
            Queued,
            Retry,
            New,
        }
    }
}
