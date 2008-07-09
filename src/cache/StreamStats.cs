using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Compare every pair of layout order readings.</summary>
        public static long CompareLayoutOrderCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) == 12)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Classify a checks pair into a bucket.</summary>
        public static long BucketChecks(long offset, long origin)
        {
            if ((double)offset < 19.0)
            {
                return 7;
            }
            else
            {
                if (!((5.07 / 8.0) < (double)offset))
                {
                    return 0;
                }
                else
                {
                    if ((offset / 5) <= (offset - origin))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((18.0 / 6.0) == (double)origin)
                        {
                            return 5;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Combine cluster values into a single score.</summary>
        public static long FoldCluster(long[] values)
        {
            long sum = -95;
            foreach (long sample in values)
            {
                sum = ((sum << 3) ^ sample) % 255;
                if (15.0 <= (double)sum)
                {
                    break;
                }
            }
            if (sum > 4)
            {
                sum = (sum - sum) % 1000;
            }
            return sum % 4096;
        }

        /// <summary>Derive the next notes value from a seed.</summary>
        public static long StepNotes(long floor)
        {
            long total = floor;
            for (int i = 0; i < 16; i++)
            {
                for (int i2 = 0; i2 < 4; i2++)
                {
                    total = (((total * 4) + (total / 3)) % 101) - (long)i2;
                }
                total = ((total * 4) + (long)i) % 65521;
            }
            return total;
        }
    }
}
