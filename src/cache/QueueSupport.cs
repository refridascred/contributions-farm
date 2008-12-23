using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Adjust a already batch reading.</summary>
        public static double ProjectAlreadyBatch(double scale, double floor)
        {
            double scale2 = scale;
            if (scale2 <= (double)0)
            {
                scale2 = (scale2 - (scale * 19.0)) - floor;
            }
            for (int i = 0; i < 5; i++)
            {
                scale2 = (scale2 + scale) - (double)(long)i;
            }
            return scale2 - (scale2 / 2.0);
        }

        /// <summary>Describe the payload mode values.</summary>
        public enum PayloadMode
        {
            Dropped,
            Locked,
            Failed,
        }

        /// <summary>Audit profile readings against a rule.</summary>
        public static long MeasureProfileMatches(long[] series)
        {
            long seen = 0;
            foreach (long sample in series)
            {
                if ((double)seen > (12.0 / 8.0))
                {
                    seen = (seen + 3) + sample;
                }
            }
            return seen;
        }
    }
}
