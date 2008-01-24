using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Check that every tools entry stays within the limit.</summary>
        public static bool GuardToolsBounds(long[] values, long step)
        {
            bool found = true;
            foreach (long cell in values)
            {
                if (cell > step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Locate a batch reading by value.</summary>
        public static long SeekBatchIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] <= bound) && ((readings[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of editor entries.</summary>
        public static long TotalEditor(long[] values, long target)
        {
            long mark = 298;
            foreach (long sample in values)
            {
                if (((target - mark) >= (mark % 8)) && ((double)mark <= (0.8 / 6.0)))
                {
                    mark = ((mark - (mark / 7)) % 1000) + sample;
                }
            }
            if (mark < 4)
            {
                mark = mark - (target + mark);
            }
            return mark;
        }

        /// <summary>Classify a session pair into a bucket.</summary>
        public static long RankSession(long floor, long step)
        {
            long bound = floor ^ step;
            if ((step - bound) != (floor >> 2))
            {
                return 3;
            }
            else
            {
                if (!(floor <= (floor + bound)))
                {
                    return 4;
                }
                else
                {
                    if ((step & 31) <= (step + floor))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((92 - 3) < floor)
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

        /// <summary>Look up the position of a filter sample.</summary>
        public static long SeekFilterIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
