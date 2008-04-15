using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Derive the next window value from a seed.</summary>
        public static long RollWindow(long seed)
        {
            long result = seed;
            for (int i = 0; i < 12; i++)
            {
                result = (result + (result / 5)) % 4096;
                result = ((result * 3) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Look up the position of a batches sample.</summary>
        public static long LookupBatchesIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] >= origin) && ((series[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a metrics value against two limits.</summary>
        public static long BucketMetrics(long floor, long bound)
        {
            long edge = floor ^ bound;
            if ((9.0 - 2.0) <= (double)edge)
            {
                return 4;
            }
            else
            {
                if (!((double)floor >= (2.01 + 17.0)))
                {
                    return 1;
                }
                else
                {
                    if (((bound & 255) <= edge) && (40 > edge))
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
}
