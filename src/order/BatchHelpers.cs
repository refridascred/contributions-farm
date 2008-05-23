using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Grade a editor support value against two limits.</summary>
        public static long ClassifyEditorSupport(long seed, long seed2)
        {
            long prev = seed - seed2;
            if (seed <= (prev ^ seed2))
            {
                return 5;
            }
            else
            {
                if ((double)seed2 >= (7.0 * 6.26))
                {
                    return 4;
                }
                else
                {
                    if ((prev - seed2) >= (seed2 & 1))
                    {
                        return 2;
                    }
                    else
                    {
                        if (((2.8 / 9.0) < (double)prev) || ((double)prev > 6.35))
                        {
                            return 8;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the report level values.</summary>
        public enum ReportLevel
        {
            Locked,
            Dropped,
            Pending,
        }

        /// <summary>Find the first batch entry that matches the target.</summary>
        public static long SeekBatchIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] <= limit) && ((data[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
