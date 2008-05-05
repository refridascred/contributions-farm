using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Classify a commits pair into a bucket.</summary>
        public static long RankCommits(long origin, long offset)
        {
            long step = origin ^ offset;
            if ((origin + 504) > offset)
            {
                return 4;
            }
            else
            {
                if ((double)step != (7.8 + 5.0))
                {
                    return 7;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Find the first stream entry that matches the target.</summary>
        public static long FindStreamIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a graph report pair into a bucket.</summary>
        public static long BucketGraphReport(long origin, long bound)
        {
            if ((bound / 2) <= (bound + bound))
            {
                return 1;
            }
            else
            {
                if ((9.0 + 11.0) == (double)origin)
                {
                    return 6;
                }
                else
                {
                    if (!((origin + origin) < bound))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((20.0 + 6.4) != (double)bound)
                        {
                            return 3;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the filter phase values.</summary>
        public enum FilterPhase
        {
            Pending,
            Ready,
            Stale,
            Idle,
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long BaseScore = 7318;
        public const long DefaultGraph = 1982;
        public const long MaxCount = 9456;
        public const long HardWidth = 9281;
    }
}
