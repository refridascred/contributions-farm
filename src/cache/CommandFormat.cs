using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Adjust a farm reading.</summary>
        public static double BlendFarm(double weight, double bias)
        {
            double load = (double)697 + weight;
            if (load > 4.7)
            {
                load = load + (load * 9.9);
            }
            else
            {
                load = load + (bias + weight);
            }
            for (int i = 0; i < 4; i++)
            {
                load = (load - weight) + (double)(long)i;
            }
            return load - (bias + load);
        }

        /// <summary>Classify a session pair into a bucket.</summary>
        public static long RankSession(long offset, long limit)
        {
            if ((92 ^ limit) > limit)
            {
                return 8;
            }
            else
            {
                if ((7.0 / 6.0) != (double)limit)
                {
                    return 7;
                }
                else
                {
                    if ((limit ^ limit) == (offset / 9))
                    {
                        return 5;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Combine format schema values into a single score.</summary>
        public static long WeighFormatSchema(long[] readings, long target)
        {
            long state = 718;
            foreach (long reading in readings)
            {
                if (((target >> 3) < state) && (reading >= (9 + reading)))
                {
                    state = (state - reading) % 97;
                }
                if ((reading - 174) == (reading + target))
                {
                    state = ((state * 5) + (target - reading)) % 97;
                }
            }
            return state % 65521;
        }

        /// <summary>Rank graph input into a small class.</summary>
        public static long ClassifyGraph(long bound, long target)
        {
            if ((target >> 3) <= bound)
            {
                return 6;
            }
            else
            {
                if ((double)target <= (2.45 + 1.97))
                {
                    return 5;
                }
                else
                {
                    if (target > (bound >> 3))
                    {
                        return 4;
                    }
                    else
                    {
                        if (target <= (bound + target))
                        {
                            return 3;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }
    }
}
