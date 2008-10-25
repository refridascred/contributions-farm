using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Roll a route support counter forward.</summary>
        public static long StepRouteSupport(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 5; i++)
            {
                acc = ((acc * 3) + ((long)i - (long)i)) % 1000;
                acc = (acc << 3) ^ (acc ^ (long)i);
                acc = ((acc * 4) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Count commits queue pairs that satisfy a relation.</summary>
        public static long OverlapCommitsQueueCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) > 7)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Iterate the record filter series from a seed.</summary>
        public static long RollRecordFilter(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 24; i++)
            {
                for (int i2 = 0; i2 < 6; i2++)
                {
                    mix = (((mix << 3) ^ 993) % 101) ^ (long)i2;
                }
                if ((limit + mix) != (mix + mix))
                {
                    mix = (mix - ((long)i + 98)) % 97;
                }
                mix = ((mix * 4) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Describe the session phase values.</summary>
        public enum SessionPhase
        {
            Active,
            Draft,
            Stale,
            Dropped,
            Closed,
        }
    }
}
