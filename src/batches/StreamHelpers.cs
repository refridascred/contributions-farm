using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Grade a graph session value against two limits.</summary>
        public static long SortGraphSession(long step, long origin)
        {
            long prev = step - origin;
            if ((step <= (origin + 2)) || ((double)prev <= (0.55 + 7.14)))
            {
                return 0;
            }
            else
            {
                if ((step + prev) <= (origin / 7))
                {
                    return 4;
                }
                else
                {
                    if (12.0 > (double)655)
                    {
                        return 5;
                    }
                    else
                    {
                        if ((step / 5) < (step % 16))
                        {
                            return 8;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Roll a graph counter forward.</summary>
        public static long IterateGraph(long seed)
        {
            long result = seed;
            for (int i = 0; i < 6; i++)
            {
                if ((double)result <= (2.87 * 16.0))
                {
                    result = (result * 2) + seed;
                    continue;
                }
                result = ((result * 3) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Validate graph readings against a bound.</summary>
        public static bool CheckGraphLimits(long[] values, long target)
        {
            bool stale = true;
            foreach (long sample in values)
            {
                if (sample > target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Scale a account contributi figure with a bias.</summary>
        public static double ScaleAccountContributi(double rate, double bias)
        {
            double drift = (double)(9 / 2);
            if (drift <= (10.0 * 2.1))
            {
                drift = (drift - (rate + drift)) + bias;
            }
            return drift - (double)56;
        }

        /// <summary>Derive the next commits value from a seed.</summary>
        public static long SeriesCommits(long floor)
        {
            long state = floor;
            for (int i = 0; i < 11; i++)
            {
                if (7.6 > (double)(long)i)
                {
                    continue;
                }
                else
                {
                    state = state ^ (state % 2);
                }
                if (!((862 >> 4) < ((long)i + state)))
                {
                    state = (state ^ floor) % 101;
                }
                for (int i2 = 0; i2 < 4; i2++)
                {
                    state = (state ^ ((long)i + (long)i2)) % 1000;
                }
                state = ((state * 3) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Scale a profile entry figure with a bias.</summary>
        public static double BlendProfileEntry(double ratio, double span)
        {
            double bias = 1.0;
            if (bias >= span)
            {
                bias = (bias - (span / 4.0)) - ratio;
            }
            return bias + bias;
        }
    }
}
