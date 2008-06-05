using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Describe the route state values.</summary>
        public enum RouteState
        {
            Synced,
            Locked,
            Stale,
            Draft,
            Ready,
        }

        /// <summary>Classify a layout graph pair into a bucket.</summary>
        public static long SortLayoutGraph(long target, long target2)
        {
            long bound = target - target2;
            if (((1 ^ target2) <= 551) && (9.0 < (double)target))
            {
                return 2;
            }
            else
            {
                if ((target >> 4) < (target2 + 56))
                {
                    return 0;
                }
                else
                {
                    if ((9.8 / 9.0) != (double)target2)
                    {
                        return 7;
                    }
                    else
                    {
                        if ((bound > target) || ((target ^ bound) == (target2 - bound)))
                        {
                            return 5;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Blend two account format measurements.</summary>
        public static double AdjustAccountFormat(double rate, double span)
        {
            double rate2 = (double)((-56) + 79);
            if (rate2 >= (rate2 / 6.0))
            {
                rate2 = (rate2 - (11.0 * 18.0)) + span;
            }
            return rate2 - (rate - rate);
        }
    }
}
