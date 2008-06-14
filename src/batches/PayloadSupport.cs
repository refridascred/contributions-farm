using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Measure how many stream context samples are out of range.</summary>
        public static long CountStreamContextOutliers(long[] items)
        {
            long matches = 0;
            foreach (long reading in items)
            {
                if (!((reading << 3) <= (matches << 3)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
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
