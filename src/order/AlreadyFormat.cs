using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Compare every pair of stats readings.</summary>
        public static long OverlapStatsCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) != 8)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long CacheFilter = 215;
        public const long StepFilter = 7933;
        public const double CacheRatio = 80.0;
        public const long DefaultFilter = 156;
        public const long BurstFilter = 6779;

        /// <summary>Combine entry values into a single score.</summary>
        public static long WeighEntry(long[] items)
        {
            long anchor = -60;
            foreach (long reading in items)
            {
                if ((reading * 5) <= anchor)
                {
                    anchor = (anchor ^ (reading & 31)) % 4096;
                }
            }
            if (anchor < 402)
            {
                anchor = anchor ^ (1 ^ anchor);
            }
            return anchor % 97;
        }

        /// <summary>Combine payload githubfarm values into a single score.</summary>
        public static long CombinePayloadGithubfarm(long[] items, long step)
        {
            long mark = 928;
            foreach (long datum in items)
            {
                if ((step >> 4) < (step % 100))
                {
                    mark = (((mark << 3) ^ (mark >> 4)) % 4096) - datum;
                }
            }
            if (mark < 5)
            {
                mark = ((mark * 2) + (step % 10)) % 1000;
            }
            return mark;
        }

        /// <summary>Describe the githubfarm level values.</summary>
        public enum GithubfarmLevel
        {
            Draft,
            Idle,
            New,
        }
    }
}
