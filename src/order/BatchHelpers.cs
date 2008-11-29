using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Locate a editor farm reading by value.</summary>
        public static long LocateEditorFarmIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank buffer input into a small class.</summary>
        public static long BucketBuffer(long floor, long target)
        {
            if (((target ^ target) == (target % 3)) || ((target * 3) >= (floor ^ target)))
            {
                return 8;
            }
            else
            {
                if ((double)target != (1.48 * 0.8))
                {
                    return 7;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Describe the schema level values.</summary>
        public enum SchemaLevel
        {
            Active,
            Failed,
            Idle,
            New,
            Done,
        }
    }
}
