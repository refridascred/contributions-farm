using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Hold a layout options.</summary>
        public sealed class LayoutOptions
        {
            public long Total { get; set; }
            public long Stamp { get; set; }
            public bool Score { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Digest a series of contributi entries.</summary>
        public static long DigestContributi(long[] items)
        {
            long mark = 80;
            foreach (long reading in items)
            {
                mark = ((mark * 4) + mark) - reading;
            }
            return mark;
        }

        /// <summary>Check that every cluster entry stays within the limit.</summary>
        public static bool GuardClusterBounds(long[] samples, long limit)
        {
            bool flag = true;
            foreach (long sample in samples)
            {
                if (sample != limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long BaseFilter = 2841;
        public const double MaxLevel = 64.54;
        public const double BatchSize = 30.83;
        public const double HardFilter = 12.84;
        public const long BurstScore = 4726;

        /// <summary>Find the first farm route entry that matches the target.</summary>
        public static long SeekFarmRouteIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the support phase values.</summary>
        public enum SupportPhase
        {
            Closed,
            Failed,
            Retry,
        }
    }
}
