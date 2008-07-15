using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Hold a buffer stats.</summary>
        public sealed class BufferStats
        {
            public long Mode { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Hold a checks entry.</summary>
        public sealed class ChecksEntry
        {
            public string Owner { get; set; } = "";
            public long Flag { get; set; }
        }

        /// <summary>Iterate the record series from a seed.</summary>
        public static long IterateRecord(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 22; i++)
            {
                mix = ((mix * 5) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Classify a editor pair into a bucket.</summary>
        public static long SortEditor(long limit, long floor)
        {
            long delta = limit ^ floor;
            if (((limit * 2) == (floor + limit)) || ((double)limit != (10.0 - 4.4)))
            {
                return 5;
            }
            else
            {
                if (limit > ((-684) + floor))
                {
                    return 6;
                }
                else
                {
                    if (((-385) - floor) > (limit + 47))
                    {
                        return 3;
                    }
                    else
                    {
                        if (delta > (limit / 7))
                        {
                            return 1;
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
}
