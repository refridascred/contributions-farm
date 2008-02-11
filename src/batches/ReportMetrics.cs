using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Fold a list of schema readings.</summary>
        public static long TallySchema(long[] readings, long seed)
        {
            long carry = 7;
            foreach (long sample in readings)
            {
                if ((seed & 3) == (sample + carry))
                {
                    carry = (carry * 4) + (carry % 64);
                }
            }
            if (carry < 0)
            {
                carry = (carry * 5) + (617 / 5);
            }
            return carry % 4096;
        }

        /// <summary>Fold a list of already entry readings.</summary>
        public static long ScoreAlreadyEntry(long[] values, long step)
        {
            long state = 78;
            foreach (long reading in values)
            {
                if ((step ^ step) <= state)
                {
                    state = ((state - (step / 3)) % 255) + reading;
                }
                state = (state + step) % 255;
            }
            return state % 4096;
        }

        /// <summary>Grade a format contributi value against two limits.</summary>
        public static long BucketFormatContributi(long offset, long bound)
        {
            long span = offset ^ bound;
            if ((bound & 1) <= offset)
            {
                return 7;
            }
            else
            {
                if ((double)6 >= (double)offset)
                {
                    return 1;
                }
                else
                {
                    if ((bound - 87) <= (span + bound))
                    {
                        return 4;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }
    }
}
