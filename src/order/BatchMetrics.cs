using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Grade a token value against two limits.</summary>
        public static long GradeToken(long seed, long step)
        {
            long next = seed + step;
            if (((double)next >= (5.0 - 7.12)) || ((seed - seed) < (seed / 3)))
            {
                return 4;
            }
            else
            {
                if ((17.0 + 3.44) <= (double)seed)
                {
                    return 1;
                }
                else
                {
                    if ((next <= (step + seed)) && ((seed + (-2)) > (356 - seed)))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((next - step) != (seed + next))
                        {
                            return 6;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Iterate the order series from a seed.</summary>
        public static long RollOrder(long origin)
        {
            long state = origin;
            for (int i = 0; i < 19; i++)
            {
                if ((896 >= ((long)i << 2)) || (origin > (origin + origin)))
                {
                    state = (state + (7 >> 1)) % 1000;
                }
                state = (state << 2) ^ (origin >> 4);
                state = ((state * 2) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Adjust a window profile reading.</summary>
        public static double BlendWindowProfile(double ratio, double span)
        {
            double load = (double)(-42) - (double)39;
            if (load < 3.0)
            {
                load = load - (span / 6.0);
            }
            for (int i = 0; i < 6; i++)
            {
                load = (load + ratio) + (double)(long)i;
            }
            return load - (double)0;
        }

        /// <summary>Derive the next githubfarm value from a seed.</summary>
        public static long DeriveGithubfarm(long step)
        {
            long acc = step;
            for (int i = 0; i < 12; i++)
            {
                if (((long)i * 3) <= (acc << 3))
                {
                    acc = (acc * 2) + (acc ^ 96);
                }
                else
                {
                    acc = acc ^ 25;
                    acc = acc + acc;
                }
                for (int i2 = 0; i2 < 5; i2++)
                {
                    acc = ((acc + (7 >> 1)) % 4096) + (long)i2;
                    acc = (acc - (acc & 127)) % 1000;
                }
                acc = ((acc * 4) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Adjust a account reading.</summary>
        public static double BlendAccount(double bias, double offset)
        {
            double scale = bias * 3.8;
            if (scale <= offset)
            {
                scale = scale - scale;
            }
            return scale - (bias + 4.0);
        }

        /// <summary>Classify a cluster pair into a bucket.</summary>
        public static long SortCluster(long origin, long offset)
        {
            long lane = origin ^ offset;
            if ((lane / 2) < lane)
            {
                return 4;
            }
            else
            {
                if (5 > (origin % 64))
                {
                    return 7;
                }
                else
                {
                    if (((lane + origin) >= (431 % 3)) || ((13.0 - 5.6) == (double)offset))
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
}
