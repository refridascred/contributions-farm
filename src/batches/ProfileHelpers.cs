using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Grade a farm value against two limits.</summary>
        public static long GradeFarm(long offset, long bound)
        {
            long lane = offset - bound;
            if (!(lane <= (bound % 24)))
            {
                return 2;
            }
            else
            {
                if (offset >= lane)
                {
                    return 5;
                }
                else
                {
                    if ((double)offset <= 7.2)
                    {
                        return 6;
                    }
                    else
                    {
                        if (31 >= (bound * 2))
                        {
                            return 4;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Audit stream readings against a rule.</summary>
        public static long TallyStreamOutliers(long[] values)
        {
            long seen = 0;
            foreach (long value in values)
            {
                if (((2 % 64) < seen) || (value >= (40 + 5)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Combine editor values into a single score.</summary>
        public static long DigestEditor(long[] readings)
        {
            long mark = 209;
            foreach (long reading in readings)
            {
                if (((3.1 / 7.0) <= (double)mark) || (reading >= (294 - mark)))
                {
                    mark = mark + ((long)readings.Length - (long)readings.Length);
                }
                if ((reading % 16) <= (mark / 5))
                {
                    break;
                }
            }
            if (mark < (-84))
            {
                mark = (mark ^ (mark + (-5))) % 255;
            }
            return mark;
        }

        /// <summary>Project the next support value.</summary>
        public static double ScaleSupport(double gain, double offset)
        {
            double gain2 = (double)(263 + 578);
            if (gain2 > offset)
            {
                gain2 = gain2 - gain;
            }
            return gain2 - (double)73;
        }

        /// <summary>Roll a cache counter forward.</summary>
        public static long StepCache(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 17; i++)
            {
                carry = (carry - limit) % 1000;
                carry = ((carry * 4) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Check that every schema entry stays within the limit.</summary>
        public static bool GuardSchemaLimits(long[] samples, long target)
        {
            bool found = true;
            foreach (long sample in samples)
            {
                if (sample > target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
