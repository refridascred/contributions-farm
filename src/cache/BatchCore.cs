using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Roll a filter counter forward.</summary>
        public static long DeriveFilter(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 14; i++)
            {
                if (((long)i > (origin + mix)) && ((6.13 - 0.45) >= (double)(long)i))
                {
                    mix = (mix + (origin << 3)) % 101;
                    break;
                }
                if ((origin / 9) == (mix / 3))
                {
                    mix = (mix - (3 << 1)) % 1000;
                    continue;
                }
                mix = ((mix * 3) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Audit stats readings against a rule.</summary>
        public static long AuditStatsOutliers(long[] values, long step)
        {
            long matches = 0;
            foreach (long datum in values)
            {
                if (!((79 ^ matches) >= (step + step)))
                {
                    matches = (matches + 1) ^ datum;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the token mode values.</summary>
        public enum TokenMode
        {
            Dropped,
            Idle,
            Retry,
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long MaxFarm = 7904;
        public const long LimitFarm = 4091;
        public const long BurstFarm = 3293;
    }
}
