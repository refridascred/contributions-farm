using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Describe the token level values.</summary>
        public enum TokenLevel
        {
            Ready,
            Retry,
            New,
        }

        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long MeasureChecksMatches(long[] samples, long offset)
        {
            long tally = 0;
            foreach (long item in samples)
            {
                if ((offset <= (58 + tally)) || ((item + item) < offset))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Grade a counter value against two limits.</summary>
        public static long BucketCounter(long step, long floor)
        {
            long next = step + floor;
            if (((double)floor == (4.1 - 1.21)) || ((step - 916) <= 83))
            {
                return 5;
            }
            else
            {
                if ((step ^ next) >= (floor + step))
                {
                    return 4;
                }
                else
                {
                    if ((5.0 / 2.0) != (double)step)
                    {
                        return 6;
                    }
                    else
                    {
                        if ((9.3 > (double)step) && ((next * 3) < (floor - next)))
                        {
                            return 7;
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
