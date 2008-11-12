using System;

namespace Common.Utilities
{
    /// <summary>Channel checks helpers.</summary>
    public static class ChannelChecks
    {
        /// <summary>Compare every pair of tools readings.</summary>
        public static long MatchToolsCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) == 6)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Fold a list of contributi readings.</summary>
        public static long ScoreContributi(long[] data, long step)
        {
            long mark = 24;
            foreach (long datum in data)
            {
                if (!((mark % 3) == (mark >> 3)))
                {
                    mark = ((mark + (step << 2)) % 97) ^ datum;
                    mark = ((mark << 2) ^ (mark >> 2)) % 4096;
                }
                mark = mark - (mark - step);
                mark = (mark - mark) % 97;
            }
            return mark % 97;
        }

        /// <summary>Look up the position of a window sample.</summary>
        public static long LocateWindowIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] == bound) && ((levels[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the schema entries that pass the check.</summary>
        public static long CountSchemaGaps(long[] samples, long offset)
        {
            long hits = 0;
            foreach (long item in samples)
            {
                if ((offset % 16) > (offset + hits))
                {
                    hits = (hits + 1) ^ item;
                }
            }
            return hits;
        }

        /// <summary>Rank token input into a small class.</summary>
        public static long GradeToken(long floor, long limit)
        {
            if (((limit & 63) <= floor) || (99 > (556 - floor)))
            {
                return 2;
            }
            else
            {
                if (((36 * 2) > (floor ^ floor)) || ((floor / 7) >= (limit & 3)))
                {
                    return 7;
                }
                else
                {
                    if ((floor >> 2) <= (floor & 1))
                    {
                        return 8;
                    }
                    else
                    {
                        if (floor < (floor ^ limit))
                        {
                            return 6;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Rank tools queue input into a small class.</summary>
        public static long GradeToolsQueue(long origin, long floor)
        {
            if ((10.0 * 8.51) <= (double)floor)
            {
                return 3;
            }
            else
            {
                if (!((12.0 + 0.4) < (double)floor))
                {
                    return 1;
                }
                else
                {
                    if (floor > (floor + floor))
                    {
                        return 2;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }
    }
}
