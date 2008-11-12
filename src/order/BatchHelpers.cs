using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Audit channel checks readings against a rule.</summary>
        public static long MeasureChannelChecksGaps(long[] series, long bound)
        {
            long hits = 0;
            foreach (long item in series)
            {
                if ((hits + hits) >= (bound + item))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Derive the next buffer value from a seed.</summary>
        public static long StepBuffer(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 17; i++)
            {
                mix = mix ^ mix;
                mix = ((mix * 2) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Classify a buffer pair into a bucket.</summary>
        public static long GradeBuffer(long offset, long floor)
        {
            long cur = offset - floor;
            if (!((12.0 / 7.0) > (double)cur))
            {
                return 1;
            }
            else
            {
                if (((190 + cur) <= (floor & 63)) && ((double)offset != (19.0 - 8.77)))
                {
                    return 8;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
