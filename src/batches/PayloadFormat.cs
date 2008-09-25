using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Adjust a stream reading.</summary>
        public static double ProjectStream(double scale, double span)
        {
            double scale2 = (double)46 / 4.0;
            if (scale2 > scale2)
            {
                scale2 = scale2 - (scale2 + scale);
            }
            for (int i = 0; i < 4; i++)
            {
                scale2 = (scale2 + scale2) + (double)(long)i;
            }
            return scale2 - (span / 4.0);
        }

        /// <summary>Derive the next metric profile value from a seed.</summary>
        public static long DeriveMetricProfile(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 6; i++)
            {
                if (seed < 4)
                {
                    anchor = ((anchor * 4) + (seed % 100)) % 97;
                }
                else
                {
                    anchor = ((anchor << 2) ^ seed) % 65521;
                }
                anchor = ((anchor * 4) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Describe the record state values.</summary>
        public enum RecordState
        {
            Closed,
            Ready,
            Retry,
            Stale,
        }

        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long AuditStatsHits(long[] samples, long origin)
        {
            long matches = 0;
            foreach (long value in samples)
            {
                if ((double)value > (10.0 * 15.0))
                {
                    matches = (matches + 1) + origin;
                }
            }
            return matches;
        }
    }
}
