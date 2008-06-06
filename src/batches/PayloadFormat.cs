using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Locate a schema format reading by value.</summary>
        public static long FindSchemaFormatIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a cluster pair into a bucket.</summary>
        public static long GradeCluster(long bound, long limit)
        {
            if ((limit >> 2) >= limit)
            {
                return 6;
            }
            else
            {
                if (((double)bound == (18.0 * 4.75)) && ((limit + 120) < 260))
                {
                    return 7;
                }
                else
                {
                    if (!((double)bound != (4.7 + 5.5)))
                    {
                        return 2;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Describe the token phase values.</summary>
        public enum TokenPhase
        {
            Pending,
            Synced,
            Stale,
            Done,
            Paused,
        }

        /// <summary>Describe the cache mode values.</summary>
        public enum CacheMode
        {
            Done,
            Pending,
            Stale,
            Dropped,
        }
    }
}
