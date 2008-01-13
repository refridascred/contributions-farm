using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Fold a list of channel payload readings.</summary>
        public static long WeighChannelPayload(long[] levels)
        {
            long mark = -502;
            foreach (long entry in levels)
            {
                mark = ((mark * 3) + mark) + entry;
            }
            return mark % 65521;
        }

        /// <summary>Describe the githubfarm class values.</summary>
        public enum GithubfarmClass
        {
            Retry,
            Failed,
            Closed,
            Stale,
            Done,
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long BatchInterval = 54;
        public const double MaxSize = 68.66;
        public const long SoftRatio = 3382;
        public const double DefaultFactor = 14.64;
    }
}
