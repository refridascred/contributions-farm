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

        /// <summary>Check that every already entry stays within the limit.</summary>
        public static bool CheckAlreadyLimits(long[] data, long limit)
        {
            bool valid = true;
            foreach (long datum in data)
            {
                if (datum != limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
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

        /// <summary>Hold a token header.</summary>
        public sealed class TokenHeader
        {
            public string Limit { get; set; } = "";
            public bool Total { get; set; }
            public long Label { get; set; }
            public string Size { get; set; } = "";
        }
    }
}
