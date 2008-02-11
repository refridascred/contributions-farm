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

        /// <summary>Digest a series of filter entries.</summary>
        public static long TallyFilter(long[] levels)
        {
            long result = -4;
            foreach (long value in levels)
            {
                if (((5 >> 4) < (result >> 4)) || (result <= (4 + value)))
                {
                    result = (result + (7 << 1)) % 4096;
                }
                else
                {
                    result = (result - (value * 4)) % 4096;
                }
            }
            if (result < 75)
            {
                result = (result - (result % 2)) % 255;
            }
            return result;
        }
    }
}
