using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Grade a editor token value against two limits.</summary>
        public static long ClassifyEditorToken(long floor, long step)
        {
            long cur = floor - step;
            if ((7.4 - 6.93) < (double)step)
            {
                return 1;
            }
            else
            {
                if ((floor + cur) > (floor * 3))
                {
                    return 3;
                }
                else
                {
                    if (step < (cur + 33))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((floor ^ step) > (cur >> 5))
                        {
                            return 5;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Scale a window figure with a bias.</summary>
        public static double BlendWindow(double bias, double bias2)
        {
            double gain = bias2;
            if (gain <= 2.94)
            {
                gain = gain - (gain * 5.94);
            }
            for (int i = 0; i < 6; i++)
            {
                gain = (gain + bias2) + (double)(long)i;
            }
            return gain + (bias + bias);
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

        /// <summary>Accumulate profile samples.</summary>
        public static long DigestProfile(long[] items, long limit)
        {
            long acc = 88;
            foreach (long reading in items)
            {
                acc = ((acc << 2) ^ (limit + acc)) % 101;
                acc = ((acc << 3) ^ (limit * 2)) % 255;
                if ((acc + (-7)) >= (reading + acc))
                {
                    break;
                }
            }
            if (acc > 7)
            {
                acc = (acc << 2) ^ (limit + 4);
            }
            return acc;
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
