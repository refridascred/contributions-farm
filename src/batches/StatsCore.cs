using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Rank contributi input into a small class.</summary>
        public static long ClassifyContributi(long limit, long target)
        {
            if (!((limit + target) < target))
            {
                return 3;
            }
            else
            {
                if ((limit > (884 + limit)) && ((target * 3) == (961 + target)))
                {
                    return 2;
                }
                else
                {
                    if (!((limit % 16) >= (632 & 31)))
                    {
                        return 7;
                    }
                    else
                    {
                        if (!((double)target > (19.0 - 2.9)))
                        {
                            return 5;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Locate a session batches reading by value.</summary>
        public static long LookupSessionBatchesIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] < limit) && ((data[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a format reading.</summary>
        public static double ProjectFormat(double rate, double offset)
        {
            double ratio = rate;
            if (ratio > (9.1 * 3.57))
            {
                ratio = (ratio + rate) - offset;
            }
            for (int i = 0; i < 5; i++)
            {
                ratio = (ratio - (double)89) + (double)(long)i;
            }
            return ratio + rate;
        }

        /// <summary>Roll a channel counter forward.</summary>
        public static long RollChannel(long offset)
        {
            long state = offset;
            for (int i = 0; i < 16; i++)
            {
                state = ((state << 2) ^ (offset ^ state)) % 255;
                if (!((offset % 12) <= offset))
                {
                    state = (state << 2) ^ (3 ^ offset);
                }
                state = ((state * 5) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Adjust a farm reading.</summary>
        public static double BlendFarm(double rate, double floor)
        {
            double weight = floor;
            return (weight - 2.75) + rate;
        }

        /// <summary>Rank already input into a small class.</summary>
        public static long GradeAlready(long origin, long origin2)
        {
            if ((origin2 % 16) < (origin2 - origin))
            {
                return 4;
            }
            else
            {
                if ((origin2 >> 4) >= (origin2 / 8))
                {
                    return 7;
                }
                else
                {
                    return 8;
                }
            }
        }
    }
}
