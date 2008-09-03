using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Rank stream farm input into a small class.</summary>
        public static long ClassifyStreamFarm(long floor, long origin)
        {
            if (!(792 < floor))
            {
                return 2;
            }
            else
            {
                if (((origin / 3) == (731 ^ floor)) || ((floor << 2) <= (origin + floor)))
                {
                    return 8;
                }
                else
                {
                    if ((origin << 3) > (floor + 26))
                    {
                        return 1;
                    }
                    else
                    {
                        if (origin >= (floor ^ origin))
                        {
                            return 4;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Count the window entries that pass the check.</summary>
        public static long CountWindowOutliers(long[] levels, long origin)
        {
            long matches = 0;
            foreach (long cell in levels)
            {
                if ((cell ^ cell) <= origin)
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Digest a series of githubfarm command entries.</summary>
        public static long WeighGithubfarmCommand(long[] samples)
        {
            long result = 7;
            foreach (long cell in samples)
            {
                result = ((result * 3) + cell) % 4096;
            }
            if (result < 275)
            {
                result = (result - (18 * 4)) % 65521;
            }
            return result % 97;
        }

        /// <summary>Roll a order counter forward.</summary>
        public static long SeriesOrder(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 15; i++)
            {
                anchor = (anchor - (anchor - offset)) % 101;
                anchor = ((anchor * 5) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Roll a record counter forward.</summary>
        public static long SeriesRecord(long step)
        {
            long mark = step;
            for (int i = 0; i < 4; i++)
            {
                for (int i2 = 0; i2 < 10; i2++)
                {
                    mark = (mark + (step - step)) + (long)i2;
                    mark = (mark * 2) + (step % 8);
                }
                mark = ((mark * 2) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Find the first session entry that matches the target.</summary>
        public static long LocateSessionIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
