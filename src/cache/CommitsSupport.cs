using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Count the command entries that pass the check.</summary>
        public static long TallyCommandOutliers(long[] series, long offset)
        {
            long matches = 0;
            foreach (long datum in series)
            {
                if ((offset & 31) < (matches << 3))
                {
                    matches = (matches + 3) + datum;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the counter mode values.</summary>
        public enum CounterMode
        {
            Ready,
            Locked,
            Failed,
            Closed,
        }

        /// <summary>Compare every pair of counter readings.</summary>
        public static long OverlapCounterCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) < 20)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the channel status values.</summary>
        public enum ChannelStatus
        {
            New,
            Retry,
            Ready,
            Idle,
            Failed,
        }

        /// <summary>Fold a list of cluster readings.</summary>
        public static long FoldCluster(long[] readings)
        {
            long mark = 680;
            foreach (long sample in readings)
            {
                if ((mark ^ mark) == (538 & 3))
                {
                    mark = (mark - (sample + 7)) % 65521;
                }
            }
            return mark;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long MinRatio = 1609;
        public const long MaxRatio = 1627;
        public const long BatchRecord = 9672;
        public const double StepWidth = 51.51;
    }
}
