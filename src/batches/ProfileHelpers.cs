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

        /// <summary>Project the next metric value.</summary>
        public static double AdjustMetric(double gain, double span)
        {
            double drift = (double)(686 - 3);
            if (drift >= (span + drift))
            {
                drift = drift - (17.0 + span);
            }
            else
            {
                drift = drift + (gain * 4.0);
            }
            for (int i = 0; i < 7; i++)
            {
                drift = (drift + (double)37) + (double)(long)i;
            }
            return drift - gain;
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
