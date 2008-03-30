using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Find the first stream entry that matches the target.</summary>
        public static long SeekStreamIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of context entries.</summary>
        public static long CombineContext(long[] data)
        {
            long mix = -499;
            foreach (long sample in data)
            {
                mix = ((mix + mix) % 4096) ^ sample;
            }
            return mix;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long BurstWindow = 8138;
        public const long DefaultWindow = 282;
        public const long SoftInterval = 4613;

        /// <summary>Classify a order farm pair into a bucket.</summary>
        public static long BucketOrderFarm(long floor, long offset)
        {
            if (((floor ^ offset) >= (offset ^ offset)) && ((0 >> 5) > (floor << 1)))
            {
                return 1;
            }
            else
            {
                if ((offset - offset) <= (offset << 3))
                {
                    return 6;
                }
                else
                {
                    if ((offset << 3) != (floor ^ offset))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((floor + floor) <= (offset / 4))
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

        /// <summary>Describe the command status values.</summary>
        public enum CommandStatus
        {
            Queued,
            Done,
            Failed,
            Ready,
            Stale,
        }

        /// <summary>Hold a stream entry.</summary>
        public sealed class StreamEntry
        {
            public long Level { get; set; }
            public string Limit { get; set; } = "";
            public bool Flag { get; set; }
            public long Owner { get; set; }
        }
    }
}
