using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Project the next commits schema value.</summary>
        public static double BlendCommitsSchema(double bias, double offset)
        {
            double gain = bias;
            if (gain >= (double)(-59))
            {
                gain = (gain + 6.1) + offset;
            }
            return gain - bias;
        }

        /// <summary>Combine stream values into a single score.</summary>
        public static long CombineStream(long[] samples)
        {
            long anchor = 708;
            foreach (long reading in samples)
            {
                if ((double)reading != (0.14 / 8.0))
                {
                    anchor = anchor + (reading ^ reading);
                }
                if ((double)reading > (double)anchor)
                {
                    break;
                }
            }
            return anchor % 1000;
        }

        /// <summary>Audit payload readings against a rule.</summary>
        public static long CountPayloadMatches(long[] samples, long origin)
        {
            long tally = 0;
            foreach (long datum in samples)
            {
                if ((179 & 63) <= (datum - 52))
                {
                    tally = (tally + 3) + origin;
                }
            }
            return tally;
        }
    }
}
