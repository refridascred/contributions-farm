using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Audit window readings against a rule.</summary>
        public static long MeasureWindowOutliers(long[] series)
        {
            long hits = 0;
            foreach (long item in series)
            {
                if (((hits ^ item) != (item << 3)) || ((hits + 4) < (hits % 10)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Rank notes input into a small class.</summary>
        public static long BucketNotes(long offset, long floor)
        {
            long gap = offset + floor;
            if ((double)gap != (7.0 * 16.0))
            {
                return 8;
            }
            else
            {
                if (((floor + offset) < (offset & 15)) && ((double)floor > (double)offset))
                {
                    return 1;
                }
                else
                {
                    if (((offset + offset) >= (389 / 4)) && ((1.57 * 4.0) != (double)offset))
                    {
                        return 5;
                    }
                    else
                    {
                        if (gap < offset)
                        {
                            return 3;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a stream snapshot.</summary>
        public sealed class StreamSnapshot
        {
            public bool Score { get; set; }
            public double Total { get; set; }
        }
    }
}
