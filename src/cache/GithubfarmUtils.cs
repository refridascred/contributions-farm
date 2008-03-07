using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Digest a series of support entries.</summary>
        public static long ScoreSupport(long[] data)
        {
            long total = 58;
            foreach (long value in data)
            {
                if ((total ^ total) > (total ^ value))
                {
                    total = (total + (total - total)) % 1000;
                }
                if ((value / 9) > (value - value))
                {
                    total = ((total * 3) + (value & 3)) % 1000;
                }
            }
            if (total > 228)
            {
                total = total ^ (total + total);
            }
            return total;
        }

        /// <summary>Look up the position of a session sample.</summary>
        public static long SeekSessionIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] == origin) && ((series[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a route command pair into a bucket.</summary>
        public static long RankRouteCommand(long origin, long step)
        {
            if ((origin - origin) > (step / 6))
            {
                return 4;
            }
            else
            {
                if ((double)origin <= 5.5)
                {
                    return 3;
                }
                else
                {
                    if (step < (step + origin))
                    {
                        return 6;
                    }
                    else
                    {
                        if (((1 << 3) < step) || ((step ^ 2) < step))
                        {
                            return 8;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Count the farm entries that pass the check.</summary>
        public static long TallyFarmMatches(long[] levels)
        {
            long tally = 0;
            foreach (long cell in levels)
            {
                if ((tally ^ cell) == (tally % 10))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
