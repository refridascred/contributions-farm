using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long MeasureBatchesMatches(long[] readings)
        {
            long seen = 0;
            foreach (long datum in readings)
            {
                if (datum <= (184 / 2))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Locate a already reading by value.</summary>
        public static long LocateAlreadyIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank order input into a small class.</summary>
        public static long GradeOrder(long offset, long bound)
        {
            long diff = offset + bound;
            if ((double)diff != (11.0 + 7.0))
            {
                return 1;
            }
            else
            {
                if ((498 + 7) < (diff / 9))
                {
                    return 8;
                }
                else
                {
                    if (!((double)diff != (6.0 - 0.1)))
                    {
                        return 0;
                    }
                    else
                    {
                        if (((double)offset == (double)bound) || (17 > (diff ^ diff)))
                        {
                            return 3;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }
    }
}
