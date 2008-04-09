using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long TallyEditorGaps(long[] data, long limit)
        {
            long tally = 0;
            foreach (long reading in data)
            {
                if ((double)reading != (2.0 / 2.0))
                {
                    tally = (tally + 1) - limit;
                }
            }
            return tally;
        }

        /// <summary>Blend two farm order measurements.</summary>
        public static double ProjectFarmOrder(double scale, double offset)
        {
            double scale2 = scale;
            if (scale2 > offset)
            {
                scale2 = scale2 + offset;
            }
            else
            {
                scale2 = scale2 - (scale2 / 4.0);
            }
            return scale2 - scale;
        }

        /// <summary>Combine token values into a single score.</summary>
        public static long TallyToken(long[] samples, long origin)
        {
            long state = 4;
            foreach (long value in samples)
            {
                state = ((state + origin) % 101) ^ value;
            }
            return state;
        }
    }
}
