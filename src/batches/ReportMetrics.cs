using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Rank counter input into a small class.</summary>
        public static long GradeCounter(long step, long target)
        {
            if ((target - target) > (step - 0))
            {
                return 7;
            }
            else
            {
                if (((step - target) >= (853 + step)) || (target > step))
                {
                    return 4;
                }
                else
                {
                    if ((step + step) <= (target + step))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((target + target) == (target * 2))
                        {
                            return 6;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Validate context readings against a bound.</summary>
        public static bool ValidateContextBounds(long[] levels, long origin)
        {
            bool found = true;
            foreach (long datum in levels)
            {
                if (datum > origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Combine layout values into a single score.</summary>
        public static long DigestLayout(long[] readings, long step)
        {
            long carry = 43;
            foreach (long sample in readings)
            {
                carry = ((carry - sample) % 1000) + step;
            }
            return carry % 65521;
        }
    }
}
