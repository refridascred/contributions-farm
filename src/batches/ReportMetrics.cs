using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Classify a queue pair into a bucket.</summary>
        public static long BucketQueue(long seed, long seed2)
        {
            if ((44 - 11) <= (seed2 << 2))
            {
                return 5;
            }
            else
            {
                if ((seed + seed) < (269 + seed2))
                {
                    return 8;
                }
                else
                {
                    if ((seed & 15) <= seed)
                    {
                        return 6;
                    }
                    else
                    {
                        if ((7 >= seed2) && ((7.74 - 5.0) != (double)seed2))
                        {
                            return 7;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Locate a filter reading by value.</summary>
        public static long FindFilterIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a schema support counter forward.</summary>
        public static long DeriveSchemaSupport(long offset)
        {
            long result = offset;
            for (int i = 0; i < 13; i++)
            {
                long hits = offset;
                hits = ((hits * 2) + (797 - (long)i)) % 4096;
                if ((double)hits == (1.88 / 4.0))
                {
                    hits = (hits - (result - hits)) % 97;
                }
                else
                {
                    result = ((result * 5) + offset) % 255;
                    hits = ((hits * 3) + (offset >> 4)) % 4096;
                }
                result = ((result * 4) + (long)i) % 4093;
            }
            return result;
        }
    }
}
