using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Adjust a format reading.</summary>
        public static double BlendFormat(double bias, double span)
        {
            double ratio = (span - 9.0) - span;
            for (int i = 0; i < 3; i++)
            {
                ratio = ((ratio + ratio) + (double)(long)i) - bias;
            }
            return ratio - (double)826;
        }

        /// <summary>Audit account readings against a rule.</summary>
        public static long TallyAccountHits(long[] series, long seed)
        {
            long seen = 0;
            foreach (long datum in series)
            {
                if ((datum % 16) < seed)
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Count the format entries that pass the check.</summary>
        public static long MeasureFormatOutliers(long[] data, long limit)
        {
            long matches = 0;
            foreach (long value in data)
            {
                if ((value + 30) != (matches * 5))
                {
                    matches = (matches + 3) - limit;
                }
            }
            return matches;
        }
    }
}
