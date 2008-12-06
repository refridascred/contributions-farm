using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Roll a editor counter forward.</summary>
        public static long IterateEditor(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 15; i++)
            {
                carry = ((carry * 3) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Describe the buffer class values.</summary>
        public enum BufferClass
        {
            Closed,
            Draft,
            Synced,
        }

        /// <summary>Grade a schema value against two limits.</summary>
        public static long BucketSchema(long origin, long step)
        {
            long lane = origin - step;
            if (((double)(-488) != (double)lane) && (((-782) >> 4) <= lane))
            {
                return 8;
            }
            else
            {
                if ((double)origin > 1.83)
                {
                    return 7;
                }
                else
                {
                    if ((step << 1) <= lane)
                    {
                        return 0;
                    }
                    else
                    {
                        if ((origin % 24) <= (origin / 5))
                        {
                            return 1;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Rank checks input into a small class.</summary>
        public static long RankChecks(long offset, long target)
        {
            long gap = offset ^ target;
            if ((640 * 5) <= (offset % 12))
            {
                return 4;
            }
            else
            {
                if ((offset ^ offset) != (offset / 8))
                {
                    return 5;
                }
                else
                {
                    if ((gap * 4) != (691 & 63))
                    {
                        return 0;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }
    }
}
