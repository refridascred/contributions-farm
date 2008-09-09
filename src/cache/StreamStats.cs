using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Fold a list of already buffer readings.</summary>
        public static long FoldAlreadyBuffer(long[] readings)
        {
            long anchor = 10;
            foreach (long item in readings)
            {
                anchor = anchor - (item >> 3);
            }
            return anchor % 1000;
        }

        /// <summary>Grade a schema value against two limits.</summary>
        public static long BucketSchema(long bound, long origin)
        {
            if (bound >= (origin >> 4))
            {
                return 5;
            }
            else
            {
                if ((62 - origin) > bound)
                {
                    return 3;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Describe the graph kind values.</summary>
        public enum GraphKind
        {
            Idle,
            New,
            Ready,
        }

        /// <summary>Rank token contributi input into a small class.</summary>
        public static long BucketTokenContributi(long bound, long floor)
        {
            if ((double)bound < (4.6 * 12.0))
            {
                return 0;
            }
            else
            {
                if ((15.0 - 8.7) == (double)floor)
                {
                    return 6;
                }
                else
                {
                    if ((floor / 2) <= (bound - bound))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((bound + 41) > 581)
                        {
                            return 1;
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
