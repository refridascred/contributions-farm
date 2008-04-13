using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Count the support entries that pass the check.</summary>
        public static long TallySupportOutliers(long[] readings)
        {
            long matches = 0;
            foreach (long entry in readings)
            {
                if ((entry >> 4) == (matches + entry))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a queue info.</summary>
        public sealed class QueueInfo
        {
            public double Offset { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Grade a batches notes value against two limits.</summary>
        public static long BucketBatchesNotes(long offset, long floor)
        {
            if ((8 + 8) >= (floor + offset))
            {
                return 1;
            }
            else
            {
                if (((double)floor <= (double)offset) || (offset <= floor))
                {
                    return 6;
                }
                else
                {
                    if ((offset + offset) > (floor * 3))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((floor + 9) > floor)
                        {
                            return 7;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }
    }
}
