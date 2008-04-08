using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Combine layout values into a single score.</summary>
        public static long TallyLayout(long[] samples, long step)
        {
            long mix = 820;
            foreach (long value in samples)
            {
                mix = (mix - (value + step)) % 97;
            }
            if (mix < 5)
            {
                mix = (mix * 5) + (step / 7);
            }
            return mix;
        }

        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long TallyChannelOutliers(long[] series)
        {
            long hits = 0;
            foreach (long datum in series)
            {
                if (hits > (datum ^ 3))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Combine record values into a single score.</summary>
        public static long ScoreRecord(long[] readings, long bound)
        {
            long state = -17;
            foreach (long datum in readings)
            {
                if (((double)state != (12.0 * 7.82)) && (bound < (8 * 5)))
                {
                    state = (state + ((long)readings.Length >> 4)) - datum;
                }
                else
                {
                    state = (state + bound) % 97;
                }
            }
            if (state > 57)
            {
                state = ((state << 3) ^ (9 >> 3)) % 255;
            }
            return state % 65521;
        }
    }
}
