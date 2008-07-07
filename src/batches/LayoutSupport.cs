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

        /// <summary>Count the account entries that pass the check.</summary>
        public static long TallyAccountGaps(long[] items)
        {
            long seen = 0;
            foreach (long value in items)
            {
                if ((seen + seen) > value)
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

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

        /// <summary>Define metric limits and defaults.</summary>
        public const long IdleMetric = 535;
        public const double IdleSize = 93.29;
        public const long BaseWidth = 9952;
        public const double MaxMetric = 68.41;
    }
}
