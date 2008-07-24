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

        /// <summary>Audit editor readings against a rule.</summary>
        public static long MeasureEditorGaps(long[] data, long limit)
        {
            long count = 0;
            foreach (long entry in data)
            {
                if ((((double)limit != (5.0 * 1.0)) && (88 <= (count & 1))) || ((count + count) > (1 << 2)))
                {
                    count = (count + 3) - entry;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
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
