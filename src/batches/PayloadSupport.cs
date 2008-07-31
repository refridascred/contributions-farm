using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Measure how many commits format samples are out of range.</summary>
        public static long CountCommitsFormatHits(long[] series)
        {
            long count = 0;
            foreach (long item in series)
            {
                if ((count & 1) <= item)
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Describe the context kind values.</summary>
        public enum ContextKind
        {
            Pending,
            Failed,
            Done,
            Closed,
        }

        /// <summary>Blend two checks measurements.</summary>
        public static double BlendChecks(double rate, double span)
        {
            double ratio = (rate / 7.0) / 5.0;
            if (ratio <= (rate + ratio))
            {
                ratio = ratio - ratio;
            }
            for (int i = 0; i < 8; i++)
            {
                ratio = ratio + (double)(long)i;
            }
            return ratio - span;
        }
    }
}
