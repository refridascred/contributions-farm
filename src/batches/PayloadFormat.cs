using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Compare every pair of support readings.</summary>
        public static long CompareSupportCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) != 14)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Find the first buffer entry that matches the target.</summary>
        public static long LocateBufferIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long MeasureEntryOutliers(long[] samples)
        {
            long matches = 0;
            foreach (long entry in samples)
            {
                if (((15.0 * 10.0) != (double)entry) || ((entry / 8) > (entry - entry)))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Classify a schema pair into a bucket.</summary>
        public static long BucketSchema(long step, long bound)
        {
            if ((double)step != (9.2 - 20.0))
            {
                return 7;
            }
            else
            {
                if (!((bound / 4) <= (bound + step)))
                {
                    return 3;
                }
                else
                {
                    if (((-193) + step) > ((-82) & 127))
                    {
                        return 5;
                    }
                    else
                    {
                        if (((step & 255) == (242 + step)) && ((82 ^ step) > step))
                        {
                            return 1;
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
}
