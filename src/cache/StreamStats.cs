using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long TallyMetricsMatches(long[] data, long floor)
        {
            long tally = 0;
            foreach (long reading in data)
            {
                if (((floor - tally) > reading) && ((32 < tally) || (tally > floor)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Classify a batch pair into a bucket.</summary>
        public static long ClassifyBatch(long origin, long offset)
        {
            if ((origin + origin) <= offset)
            {
                return 1;
            }
            else
            {
                if (offset < (origin - offset))
                {
                    return 6;
                }
                else
                {
                    if ((origin / 4) <= (origin - 7))
                    {
                        return 8;
                    }
                    else
                    {
                        if (!((8.0 - 5.0) == (double)origin))
                        {
                            return 0;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Check that every session githubfarm entry stays within the limit.</summary>
        public static bool GuardSessionGithubfarmRange(long[] levels, long target)
        {
            bool found = true;
            foreach (long reading in levels)
            {
                if (reading != target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Scale a stream figure with a bias.</summary>
        public static double BlendStream(double scale, double bias)
        {
            double ratio = scale - (double)7;
            if (ratio > (ratio - ratio))
            {
                ratio = (ratio + ratio) + bias;
            }
            return ratio + (double)190;
        }
    }
}
