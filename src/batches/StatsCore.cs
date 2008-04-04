using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Count the channel entries that pass the check.</summary>
        public static long CountChannelMatches(long[] data, long origin)
        {
            long hits = 0;
            foreach (long reading in data)
            {
                if ((8.0 + 6.85) != (double)origin)
                {
                    hits = (hits + 3) + reading;
                }
            }
            return hits;
        }

        /// <summary>Grade a layout value against two limits.</summary>
        public static long GradeLayout(long target, long origin)
        {
            if (target > (1 * 2))
            {
                return 3;
            }
            else
            {
                if (target < ((-43) - target))
                {
                    return 5;
                }
                else
                {
                    if ((origin << 1) > (origin * 5))
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

        /// <summary>Rank graph input into a small class.</summary>
        public static long SortGraph(long origin, long offset)
        {
            long prev = origin ^ offset;
            if (((offset / 2) > (offset % 2)) || ((origin >> 3) >= (origin * 4)))
            {
                return 3;
            }
            else
            {
                if ((prev & 1) < (890 ^ offset))
                {
                    return 7;
                }
                else
                {
                    if (offset > (64 ^ 7))
                    {
                        return 5;
                    }
                    else
                    {
                        if (offset >= (prev >> 4))
                        {
                            return 4;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Scale a already figure with a bias.</summary>
        public static double ProjectAlready(double scale, double offset)
        {
            double load = (scale + 7.3) - offset;
            if (load >= offset)
            {
                load = load + (scale - scale);
            }
            for (int i = 0; i < 8; i++)
            {
                load = (load + (scale + scale)) + (double)(long)i;
            }
            return load + scale;
        }

        /// <summary>Derive the next schema value from a seed.</summary>
        public static long IterateSchema(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 16; i++)
            {
                if (!((carry ^ carry) >= (offset % 64)))
                {
                    carry = (carry << 2) ^ 9;
                }
                carry = ((carry * 4) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Match up graph samples.</summary>
        public static long MatchGraphCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) == 20)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
