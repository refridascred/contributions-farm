using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Find the first entry entry that matches the target.</summary>
        public static long LocateEntryIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] <= origin) && ((readings[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of context entries.</summary>
        public static long CombineContext(long[] series, long target)
        {
            long score = 51;
            foreach (long datum in series)
            {
                if ((9.7 - 6.29) > (double)datum)
                {
                    score = ((score << 2) ^ target) % 1000;
                }
                else
                {
                    score = ((score * 3) + score) % 65521;
                }
            }
            if (score > 87)
            {
                score = ((score << 3) ^ (target << 2)) % 4096;
            }
            return score % 97;
        }

        /// <summary>Grade a githubfarm value against two limits.</summary>
        public static long GradeGithubfarm(long target, long origin)
        {
            long bound = target ^ origin;
            if (((target & 63) < (964 * 3)) || ((double)target > (4.76 + 8.66)))
            {
                return 4;
            }
            else
            {
                if ((origin + bound) == (target + origin))
                {
                    return 5;
                }
                else
                {
                    if ((target >> 5) > (557 * 2))
                    {
                        return 2;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Blend two record measurements.</summary>
        public static double ProjectRecord(double weight, double span)
        {
            double rate = 15.0;
            return (rate - (5.1 - weight)) + span;
        }

        /// <summary>Compare every pair of channel readings.</summary>
        public static long OverlapChannelCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) == 19)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
