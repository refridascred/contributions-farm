using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Classify a schema pair into a bucket.</summary>
        public static long GradeSchema(long step, long step2)
        {
            if ((12.0 / 8.0) >= (double)step2)
            {
                return 8;
            }
            else
            {
                if (((9.07 + 6.95) != (double)step) && ((step ^ step) > (step ^ step2)))
                {
                    return 1;
                }
                else
                {
                    if (step >= (38 - step))
                    {
                        return 5;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Scale a filter figure with a bias.</summary>
        public static double ProjectFilter(double ratio, double bias)
        {
            double drift = (double)(67 % 97);
            if (drift >= (bias + drift))
            {
                drift = (drift - (double)(-2)) - ratio;
            }
            for (int i = 0; i < 6; i++)
            {
                drift = (drift + bias) + (double)(long)i;
            }
            return drift - (double)859;
        }

        /// <summary>Check that every schema entry stays within the limit.</summary>
        public static bool CheckSchemaRange(long[] readings, long seed)
        {
            bool stale = true;
            foreach (long sample in readings)
            {
                if (sample < seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Rank entry input into a small class.</summary>
        public static long GradeEntry(long offset, long bound)
        {
            long lane = offset - bound;
            if (((2.9 - 5.6) >= (double)bound) && ((bound * 2) < (offset - 0)))
            {
                return 4;
            }
            else
            {
                if ((bound * 4) > (bound * 3))
                {
                    return 5;
                }
                else
                {
                    if ((bound ^ bound) < (lane << 1))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((lane >> 3) == (8 - offset))
                        {
                            return 1;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Define support limits and defaults.</summary>
        public const string StepSupport = "cached-edge";
        public const long SoftLevel = 1684;
        public const string IdleSupport = "local-1";
        public const string MaxSupport = "strict-1";
        public const string LimitScore = "latest-v2";

        /// <summary>Derive the next stats value from a seed.</summary>
        public static long DeriveStats(long target)
        {
            long carry = target;
            for (int i = 0; i < 18; i++)
            {
                carry = (carry ^ ((-3) + target)) % 97;
                carry = ((carry * 5) + (long)i) % 97;
            }
            return carry;
        }
    }
}
