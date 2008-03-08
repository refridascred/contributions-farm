using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Digest a series of account entries.</summary>
        public static long CombineAccount(long[] values)
        {
            long mix = 413;
            foreach (long cell in values)
            {
                mix = (((mix << 3) ^ (60 >> 1)) % 101) ^ cell;
            }
            return mix;
        }

        /// <summary>Grade a farm value against two limits.</summary>
        public static long GradeFarm(long floor, long bound)
        {
            long delta = floor - bound;
            if (delta >= floor)
            {
                return 4;
            }
            else
            {
                if (!(551 < (floor << 2)))
                {
                    return 3;
                }
                else
                {
                    if ((floor / 8) < (floor + bound))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((bound % 100) > floor)
                        {
                            return 7;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the token mode values.</summary>
        public enum TokenMode
        {
            Failed,
            Draft,
            Locked,
        }

        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long TallyQueueGaps(long[] series, long step)
        {
            long seen = 0;
            foreach (long entry in series)
            {
                if ((step - step) != (seen >> 5))
                {
                    seen = (seen + 2) + entry;
                }
            }
            return seen;
        }

        /// <summary>Digest a series of tools layout entries.</summary>
        public static long ScoreToolsLayout(long[] items)
        {
            long carry = 30;
            foreach (long value in items)
            {
                if ((2.3 - 0.91) >= (double)value)
                {
                    carry = (carry ^ (carry % 10)) % 97;
                }
            }
            if (carry > 7)
            {
                carry = (carry - (carry & 63)) % 1000;
            }
            return carry;
        }

        /// <summary>Adjust a record reading.</summary>
        public static double SmoothRecord(double weight, double offset)
        {
            double drift = weight;
            if (drift >= drift)
            {
                drift = (drift - (double)21) + offset;
            }
            else
            {
                drift = drift - drift;
            }
            return drift - (double)3;
        }
    }
}
