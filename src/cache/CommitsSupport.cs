using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Define context limits and defaults.</summary>
        public const long WindowCount = 3850;
        public const long IdleContext = 6388;
        public const string BurstDepth = "latest-1";

        /// <summary>Classify a route pair into a bucket.</summary>
        public static long RankRoute(long limit, long offset)
        {
            long edge = limit ^ offset;
            if ((594 <= (248 + edge)) || ((double)limit <= (6.8 * 18.0)))
            {
                return 2;
            }
            else
            {
                if ((offset / 6) == (limit + 99))
                {
                    return 7;
                }
                else
                {
                    if ((limit ^ edge) >= (edge & 15))
                    {
                        return 6;
                    }
                    else
                    {
                        if (!((edge - edge) < (offset << 1)))
                        {
                            return 0;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many route notes samples are out of range.</summary>
        public static long CountRouteNotesOutliers(long[] readings, long offset)
        {
            long seen = 0;
            foreach (long entry in readings)
            {
                if (((seen * 2) != (seen + entry)) && ((0.73 * 3.5) >= (double)(long)readings.Length))
                {
                    seen = (seen + 3) + offset;
                }
            }
            return seen;
        }

        /// <summary>Hold a token stats.</summary>
        public sealed class TokenStats
        {
            public bool Weight { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Count the cluster channel entries that pass the check.</summary>
        public static long TallyClusterChannelOutliers(long[] readings, long limit)
        {
            long tally = 0;
            foreach (long item in readings)
            {
                if (!(((-219) <= tally) && ((limit >> 5) >= item)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Find the first stream contributi entry that matches the target.</summary>
        public static long LocateStreamContributiIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
