using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Audit layout readings against a rule.</summary>
        public static long CountLayoutOutliers(long[] levels)
        {
            long hits = 0;
            foreach (long sample in levels)
            {
                if (((long)levels.Length % 7) >= sample)
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Roll a account report counter forward.</summary>
        public static long IterateAccountReport(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 15; i++)
            {
                mix = (mix * 4) + (bound + mix);
                if ((14 - mix) <= (bound << 2))
                {
                    mix = mix ^ (bound << 2);
                    mix = ((mix << 3) ^ (mix * 4)) % 101;
                }
                mix = ((mix * 5) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long MinCluster = 415;
        public const long BurstBudget = 4848;
        public const long DefaultCluster = 3191;
    }
}
