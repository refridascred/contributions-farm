using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Count the stream entries that pass the check.</summary>
        public static long CountStreamOutliers(long[] samples)
        {
            long matches = 0;
            foreach (long reading in samples)
            {
                if (((double)(long)samples.Length < (double)18) && ((matches & 31) >= matches))
                {
                    matches = (matches + 2) ^ reading;
                }
            }
            return matches;
        }

        /// <summary>Match up session samples.</summary>
        public static long CompareSessionCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) == 11)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Classify a stream profile pair into a bucket.</summary>
        public static long RankStreamProfile(long bound, long origin)
        {
            if ((double)bound != (double)origin)
            {
                return 1;
            }
            else
            {
                if (((bound - origin) < origin) && ((bound + (-167)) <= bound))
                {
                    return 3;
                }
                else
                {
                    if ((3.0 / 7.0) <= (double)origin)
                    {
                        return 4;
                    }
                    else
                    {
                        if (((double)origin > (7.1 - 9.6)) || ((double)bound > (13.0 / 3.0)))
                        {
                            return 0;
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
