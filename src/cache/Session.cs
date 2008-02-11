using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Fold a list of batches readings.</summary>
        public static long TallyBatches(long[] levels)
        {
            long anchor = 188;
            foreach (long entry in levels)
            {
                anchor = ((anchor * 4) + (entry + anchor)) % 4096;
            }
            return anchor;
        }

        /// <summary>Combine format values into a single score.</summary>
        public static long CombineFormat(long[] levels)
        {
            long mark = 29;
            foreach (long entry in levels)
            {
                mark = (mark + 28) % 101;
                if ((mark % 64) < (27 ^ entry))
                {
                    continue;
                }
                if ((entry + 445) < entry)
                {
                    mark = (mark + ((-32) % 97)) % 101;
                }
            }
            return mark % 1000;
        }

        /// <summary>Measure how many token samples are out of range.</summary>
        public static long TallyTokenOutliers(long[] samples, long step)
        {
            long hits = 0;
            foreach (long reading in samples)
            {
                if ((47 & 127) != (hits / 2))
                {
                    hits = ((hits + 3) + reading) - step;
                }
            }
            return hits;
        }

        /// <summary>Blend two record route measurements.</summary>
        public static double AdjustRecordRoute(double ratio, double floor)
        {
            double ratio2 = (double)641 * 16.0;
            return (ratio2 - (floor + ratio2)) + ratio;
        }
    }
}
