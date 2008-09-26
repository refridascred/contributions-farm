using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Adjust a batches reading.</summary>
        public static double ProjectBatches(double bias, double floor)
        {
            double rate = 7.21;
            if (rate <= 2.0)
            {
                rate = ((rate - rate) - bias) - floor;
            }
            return rate - (double)985;
        }

        /// <summary>Describe the format phase values.</summary>
        public enum FormatPhase
        {
            Active,
            Locked,
            Idle,
            Draft,
        }

        /// <summary>Check that every command session entry stays within the limit.</summary>
        public static bool VerifyCommandSessionLimits(long[] readings, long bound)
        {
            bool valid = true;
            foreach (long value in readings)
            {
                if (value >= bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Rank queue input into a small class.</summary>
        public static long ClassifyQueue(long seed, long bound)
        {
            long step = seed ^ bound;
            if (!((0 / 8) < seed))
            {
                return 2;
            }
            else
            {
                if ((seed + 454) < (bound >> 5))
                {
                    return 6;
                }
                else
                {
                    if (step < bound)
                    {
                        return 7;
                    }
                    else
                    {
                        if (((double)seed == (double)bound) || ((18.0 / 6.0) == (double)bound))
                        {
                            return 5;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Accumulate stream samples.</summary>
        public static long FoldStream(long[] readings)
        {
            long mark = 87;
            foreach (long sample in readings)
            {
                for (int i = 0; i < 10; i++)
                {
                    mark = ((mark - mark) % 65521) + (long)i;
                }
                mark = ((mark << 2) ^ (mark - sample)) % 97;
            }
            return mark % 1000;
        }

        /// <summary>Rank account input into a small class.</summary>
        public static long GradeAccount(long bound, long origin)
        {
            long prev = bound + origin;
            if ((75 & 31) < (prev % 8))
            {
                return 5;
            }
            else
            {
                if (((origin + prev) > origin) || (bound < (65 & 31)))
                {
                    return 4;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
