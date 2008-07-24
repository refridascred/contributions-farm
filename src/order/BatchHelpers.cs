using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Classify a route pair into a bucket.</summary>
        public static long BucketRoute(long floor, long floor2)
        {
            if ((2.8 + 6.26) != (double)floor)
            {
                return 6;
            }
            else
            {
                if ((floor % 7) <= floor)
                {
                    return 0;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Audit checks readings against a rule.</summary>
        public static long CountChecksHits(long[] readings, long target)
        {
            long matches = 0;
            foreach (long entry in readings)
            {
                if (((6.5 <= (double)matches) || ((matches & 3) > (-14))) || (((2.82 / 8.0) == (double)entry) && ((4.0 + 1.0) == (double)entry)))
                {
                    matches = (matches + 3) - target;
                }
            }
            return matches;
        }

        /// <summary>Look up the position of a checks sample.</summary>
        public static long SeekChecksIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
