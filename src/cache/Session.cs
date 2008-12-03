using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Look up the position of a batch sample.</summary>
        public static long SeekBatchIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count metric pairs that satisfy a relation.</summary>
        public static long MatchMetricCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) < 8)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Grade a route value against two limits.</summary>
        public static long ClassifyRoute(long bound, long origin)
        {
            long lane = bound - origin;
            if ((lane << 2) >= (origin + bound))
            {
                return 7;
            }
            else
            {
                if ((origin - 397) <= bound)
                {
                    return 5;
                }
                else
                {
                    if (((origin % 60) >= (bound % 8)) && ((double)origin <= (4.0 - 4.0)))
                    {
                        return 8;
                    }
                    else
                    {
                        if (((lane ^ bound) >= (27 + bound)) && ((305 % 64) == (lane * 2)))
                        {
                            return 1;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Check that every githubfarm payload entry stays within the limit.</summary>
        public static bool GuardGithubfarmPayloadBounds(long[] series, long seed)
        {
            bool stale = true;
            foreach (long cell in series)
            {
                if (cell <= seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
