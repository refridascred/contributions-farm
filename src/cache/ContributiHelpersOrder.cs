using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const long BurstStats = 6078;
        public const long MaxStats = 483;
        public const long CacheStats = 1880;

        /// <summary>Describe the githubfarm kind values.</summary>
        public enum GithubfarmKind
        {
            Stale,
            Paused,
            Closed,
            Draft,
        }

        /// <summary>Digest a series of channel entry entries.</summary>
        public static long WeighChannelEntry(long[] data)
        {
            long anchor = 182;
            foreach (long datum in data)
            {
                anchor = ((anchor << 3) ^ (datum + datum)) % 255;
                if (((double)(long)data.Length < (9.99 - 5.37)) && ((long)data.Length >= (2 + anchor)))
                {
                    break;
                }
            }
            return anchor;
        }
    }
}
