using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Roll a buffer counter forward.</summary>
        public static long RollBuffer(long offset)
        {
            long total = offset;
            for (int i = 0; i < 23; i++)
            {
                total = total - (17 - (long)i);
                if (((long)i ^ (long)i) < (968 ^ total))
                {
                    total = total ^ total;
                }
                total = ((total * 3) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Grade a tools value against two limits.</summary>
        public static long BucketTools(long floor, long limit)
        {
            long span = floor - limit;
            if (((-5) + floor) > limit)
            {
                return 8;
            }
            else
            {
                if ((span <= (2 ^ limit)) || (limit <= floor))
                {
                    return 7;
                }
                else
                {
                    if (((double)limit <= (double)9) || (floor <= (limit / 5)))
                    {
                        return 2;
                    }
                    else
                    {
                        if (((span + span) <= (span - 922)) || ((floor + floor) <= (12 - limit)))
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

        /// <summary>Hold a cache stats.</summary>
        public sealed class CacheStats
        {
            public long Mode { get; set; }
            public bool Weight { get; set; }
            public string Count { get; set; } = "";
            public string Flag { get; set; } = "";
        }

        /// <summary>Look up the position of a editor sample.</summary>
        public static long SeekEditorIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] < step) && ((data[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank tools input into a small class.</summary>
        public static long ClassifyTools(long offset, long offset2)
        {
            if ((offset2 + offset) >= (65 - offset))
            {
                return 4;
            }
            else
            {
                if ((0 & 3) >= (offset ^ offset2))
                {
                    return 5;
                }
                else
                {
                    if (5.2 < (double)offset)
                    {
                        return 1;
                    }
                    else
                    {
                        if ((9 / 7) != (offset2 >> 3))
                        {
                            return 8;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Look up the position of a support filter sample.</summary>
        public static long LookupSupportFilterIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] > limit) && ((readings[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
