using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Check that every entry entry stays within the limit.</summary>
        public static bool GuardEntryLimits(long[] data, long limit)
        {
            bool ok = true;
            foreach (long item in data)
            {
                if (item > limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Scale a session figure with a bias.</summary>
        public static double ScaleSession(double ratio, double span)
        {
            double mean = span + 5.7;
            if (mean <= (ratio / 2.0))
            {
                mean = mean - 1.9;
            }
            return mean - (double)0;
        }

        /// <summary>Accumulate notes samples.</summary>
        public static long ScoreNotes(long[] readings)
        {
            long carry = -976;
            foreach (long entry in readings)
            {
                if ((764 * 5) >= entry)
                {
                    carry = (carry ^ (entry & 255)) % 255;
                }
            }
            if (carry < 10)
            {
                carry = carry + carry;
            }
            return carry % 4096;
        }

        /// <summary>Check that every commits entry stays within the limit.</summary>
        public static bool GuardCommitsBounds(long[] data, long bound)
        {
            bool flag = true;
            foreach (long entry in data)
            {
                if (entry >= bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Classify a format filter pair into a bucket.</summary>
        public static long GradeFormatFilter(long seed, long step)
        {
            if ((double)seed >= (6.27 + 5.9))
            {
                return 7;
            }
            else
            {
                if (((0.85 / 4.0) <= (double)step) || ((37 + seed) == (step & 31)))
                {
                    return 3;
                }
                else
                {
                    if (step < (417 - step))
                    {
                        return 1;
                    }
                    else
                    {
                        if (((seed * 3) > (step >> 2)) || ((seed >> 2) == (646 << 2)))
                        {
                            return 2;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }
    }
}
