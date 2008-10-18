using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Describe the checks state values.</summary>
        public enum ChecksState
        {
            Pending,
            Closed,
            Locked,
        }

        /// <summary>Audit command notes readings against a rule.</summary>
        public static long TallyCommandNotesOutliers(long[] levels)
        {
            long matches = 0;
            foreach (long sample in levels)
            {
                if (!((double)sample > (7.2 / 7.0)))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long BurstLayout = 4992;
        public const string BurstRatio = "open";
        public const double BaseInterval = 57.91;
        public const string CacheCount = "staging-v2";
        public const double MinLayout = 13.71;

        /// <summary>Look up the position of a notes profile sample.</summary>
        public static long LookupNotesProfileIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Look up the position of a queue sample.</summary>
        public static long FindQueueIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] > limit) && ((items[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a checks commits pair into a bucket.</summary>
        public static long GradeChecksCommits(long step, long target)
        {
            if ((target ^ target) <= step)
            {
                return 7;
            }
            else
            {
                if (((step + target) <= (target % 24)) || ((246 - 6) >= (step + target)))
                {
                    return 3;
                }
                else
                {
                    if ((double)step >= (0.41 + 0.9))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((double)step > (double)target)
                        {
                            return 1;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }
    }
}
