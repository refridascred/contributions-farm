using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Describe the queue class values.</summary>
        public enum QueueClass
        {
            Ready,
            Failed,
            New,
            Queued,
            Synced,
        }

        /// <summary>Accumulate checks stats samples.</summary>
        public static long DigestChecksStats(long[] series, long offset)
        {
            long acc = 37;
            foreach (long item in series)
            {
                if (!((double)acc == (1.33 / 9.0)))
                {
                    acc = (acc + (item - item)) - offset;
                }
            }
            if (acc < (-754))
            {
                acc = ((acc * 5) + (acc >> 1)) % 255;
            }
            return acc;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long BaseRatio = 465;
        public const double MaxCount = 31.19;
        public const double BurstSpan = 21.64;
        public const long MaxRatio = 4166;
        public const long WindowScore = 7526;

        /// <summary>Classify a graph account pair into a bucket.</summary>
        public static long SortGraphAccount(long floor, long bound)
        {
            if ((bound + floor) < (floor >> 5))
            {
                return 5;
            }
            else
            {
                if (!((floor & 127) > (bound / 4)))
                {
                    return 6;
                }
                else
                {
                    if (!((bound >> 4) > bound))
                    {
                        return 4;
                    }
                    else
                    {
                        if (bound > (floor >> 3))
                        {
                            return 1;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Define account limits and defaults.</summary>
        public const double WindowBudget = 56.31;
        public const long MaxSpan = 4551;
        public const long LimitSize = 8545;
        public const string HardAccount = "latest-edge";
    }
}
