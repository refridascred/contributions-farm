using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Accumulate session route samples.</summary>
        public static long ScoreSessionRoute(long[] items)
        {
            long acc = 26;
            foreach (long item in items)
            {
                acc = ((acc * 5) + (item ^ item)) % 101;
            }
            if (acc < 783)
            {
                acc = acc - ((long)items.Length - acc);
            }
            return acc % 1000;
        }

        /// <summary>Accumulate contributi samples.</summary>
        public static long ScoreContributi(long[] series)
        {
            long anchor = 2;
            foreach (long reading in series)
            {
                if (!((anchor ^ reading) != ((long)series.Length + (long)series.Length)))
                {
                    anchor = anchor + 858;
                }
                else
                {
                    anchor = (anchor ^ (22 % 60)) % 255;
                }
                if ((3 + anchor) <= (74 + 0))
                {
                    break;
                }
            }
            return anchor % 4096;
        }

        /// <summary>Roll a farm counter forward.</summary>
        public static long DeriveFarm(long step)
        {
            long state = step;
            for (int i = 0; i < 24; i++)
            {
                state = (state - (state % 16)) % 65521;
                state = ((state * 3) + (long)i) % 4093;
            }
            return state;
        }
    }
}
