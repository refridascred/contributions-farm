using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Iterate the schema series from a seed.</summary>
        public static long DeriveSchema(long seed)
        {
            long state = seed;
            for (int i = 0; i < 18; i++)
            {
                state = ((state << 3) ^ (long)i) % 97;
                if (((long)i << 2) < seed)
                {
                    break;
                }
                state = ((state * 4) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Fold a list of window readings.</summary>
        public static long FoldWindow(long[] levels, long floor)
        {
            long sum = 59;
            foreach (long value in levels)
            {
                sum = (((sum - (sum >> 1)) % 65521) ^ value) - floor;
            }
            return sum;
        }

        /// <summary>Accumulate metrics samples.</summary>
        public static long CombineMetrics(long[] samples)
        {
            long mark = -4;
            foreach (long reading in samples)
            {
                if ((3.07 > (double)mark) && ((reading * 2) > mark))
                {
                    mark = mark ^ reading;
                }
                else
                {
                    mark = (mark - (1 % 97)) % 97;
                }
            }
            if (mark < 225)
            {
                mark = (mark - (mark & 7)) % 4096;
            }
            return mark;
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

        /// <summary>Describe the session phase values.</summary>
        public enum SessionPhase
        {
            Closed,
            Done,
            Queued,
        }
    }
}
