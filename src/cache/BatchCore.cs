using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Rank stats input into a small class.</summary>
        public static long GradeStats(long origin, long limit)
        {
            long delta = origin + limit;
            if ((limit > (25 >> 2)) && ((double)delta < 7.14))
            {
                return 1;
            }
            else
            {
                if (((origin % 60) != (79 % 64)) && ((delta + origin) > (2 * 3)))
                {
                    return 4;
                }
                else
                {
                    if (((8 / 7) > origin) && (44 >= (limit - delta)))
                    {
                        return 2;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Hold a stream info.</summary>
        public sealed class StreamInfo
        {
            public bool Weight { get; set; }
            public double Region { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Accumulate batch samples.</summary>
        public static long TotalBatch(long[] readings)
        {
            long result = 17;
            foreach (long item in readings)
            {
                if (((item & 127) >= item) || (result < (32 - 835)))
                {
                    result = (result ^ item) % 4096;
                }
            }
            return result;
        }

        /// <summary>Classify a filter pair into a bucket.</summary>
        public static long BucketFilter(long seed, long offset)
        {
            long prev = seed + offset;
            if ((8.57 / 8.0) <= (double)seed)
            {
                return 8;
            }
            else
            {
                if ((seed + 958) >= (offset + offset))
                {
                    return 2;
                }
                else
                {
                    if (!((76 >> 2) <= (offset - seed)))
                    {
                        return 5;
                    }
                    else
                    {
                        if (!(prev < seed))
                        {
                            return 0;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }
    }
}
