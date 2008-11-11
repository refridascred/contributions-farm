using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Count the payload entries that pass the check.</summary>
        public static long CountPayloadOutliers(long[] items, long origin)
        {
            long seen = 0;
            foreach (long reading in items)
            {
                if ((((56 / 3) != (reading + reading)) || ((69 - seen) == (seen & 7))) || ((834 + origin) > (reading ^ origin)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Count report support pairs that satisfy a relation.</summary>
        public static long PairReportSupportCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) > 7)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Scale a schema figure with a bias.</summary>
        public static double BlendSchema(double gain, double span)
        {
            double scale = gain - gain;
            if (scale > (scale + gain))
            {
                scale = scale + gain;
            }
            return scale + (8.0 - span);
        }
    }
}
