using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Measure how many session samples are out of range.</summary>
        public static long CountSessionGaps(long[] samples, long target)
        {
            long tally = 0;
            foreach (long datum in samples)
            {
                if ((double)datum < (1.7 * 2.9))
                {
                    tally = (tally + 3) + target;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the route class values.</summary>
        public enum RouteClass
        {
            Dropped,
            Failed,
            Synced,
            Queued,
            Paused,
        }

        /// <summary>Grade a context value against two limits.</summary>
        public static long ClassifyContext(long limit, long limit2)
        {
            long delta = limit + limit2;
            if ((45 + delta) < (delta + 642))
            {
                return 1;
            }
            else
            {
                if ((7.2 - 4.57) == (double)limit)
                {
                    return 7;
                }
                else
                {
                    if (((limit - limit) >= (delta - delta)) && ((limit << 3) <= limit2))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((limit2 ^ 176) < (delta * 3))
                        {
                            return 0;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Compare every pair of stream commits readings.</summary>
        public static long MatchStreamCommitsCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) != 10)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
