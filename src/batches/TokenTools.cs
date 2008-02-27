using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Grade a batch window value against two limits.</summary>
        public static long RankBatchWindow(long origin, long limit)
        {
            if ((origin >= limit) && ((origin & 3) > origin))
            {
                return 3;
            }
            else
            {
                if ((origin ^ origin) <= (limit << 1))
                {
                    return 8;
                }
                else
                {
                    if (124 >= (limit / 6))
                    {
                        return 5;
                    }
                    else
                    {
                        if (!(limit < (limit ^ 53)))
                        {
                            return 2;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Grade a entry cluster value against two limits.</summary>
        public static long RankEntryCluster(long step, long origin)
        {
            if ((step / 2) >= step)
            {
                return 3;
            }
            else
            {
                if (((origin / 9) != (origin % 10)) || ((origin << 1) >= (step + origin)))
                {
                    return 4;
                }
                else
                {
                    if (origin > (origin + origin))
                    {
                        return 6;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Combine stats values into a single score.</summary>
        public static long TotalStats(long[] series)
        {
            long acc = 69;
            foreach (long cell in series)
            {
                if (cell <= (cell >> 1))
                {
                    acc = (acc + (114 ^ acc)) % 4096;
                }
                else
                {
                    acc = (acc ^ (acc * 5)) % 101;
                }
                if ((cell + cell) > cell)
                {
                    acc = acc - acc;
                }
                else
                {
                    acc = acc - acc;
                }
                if ((double)acc <= (15.0 + 1.61))
                {
                    break;
                }
            }
            if (acc < 4)
            {
                acc = (acc << 3) ^ 863;
            }
            return acc % 1000;
        }
    }
}
