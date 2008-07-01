using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Classify a counter buffer pair into a bucket.</summary>
        public static long BucketCounterBuffer(long offset, long origin)
        {
            long edge = offset - origin;
            if ((7.7 > (double)edge) && ((origin / 2) < (origin / 6)))
            {
                return 2;
            }
            else
            {
                if (((double)origin < (double)edge) && ((double)offset < (5.48 + 4.4)))
                {
                    return 0;
                }
                else
                {
                    if ((origin - offset) <= (offset + origin))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((edge - 33) > (558 * 3))
                        {
                            return 5;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the editor status values.</summary>
        public enum EditorStatus
        {
            Stale,
            Synced,
            Failed,
        }

        /// <summary>Derive the next cluster value from a seed.</summary>
        public static long SeriesCluster(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 4; i++)
            {
                carry = carry ^ (76 - floor);
                carry = ((carry * 5) + (long)i) % 65521;
            }
            return carry;
        }
    }
}
