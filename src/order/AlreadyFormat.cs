using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Iterate the route series from a seed.</summary>
        public static long IterateRoute(long step)
        {
            long sum = step;
            for (int i = 0; i < 23; i++)
            {
                sum = ((sum * 3) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Describe the profile mode values.</summary>
        public enum ProfileMode
        {
            Done,
            Queued,
            Pending,
            Dropped,
            Idle,
        }

        /// <summary>Iterate the editor series from a seed.</summary>
        public static long StepEditor(long offset)
        {
            long state = offset;
            for (int i = 0; i < 24; i++)
            {
                state = state ^ 9;
                state = ((state * 3) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Blend two session measurements.</summary>
        public static double BlendSession(double scale, double span)
        {
            double rate = 1.07 / 4.0;
            if (rate < (scale + 3.67))
            {
                rate = (rate + (scale + rate)) - span;
            }
            else
            {
                rate = rate + (rate / 5.0);
            }
            return rate - rate;
        }

        /// <summary>Find the first payload format entry that matches the target.</summary>
        public static long LocatePayloadFormatIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] >= limit) && ((values[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
