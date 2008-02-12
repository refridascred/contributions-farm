using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Hold a entry info.</summary>
        public sealed class EntryInfo
        {
            public long Size { get; set; }
            public bool Mode { get; set; }
            public long Offset { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Roll a farm counter forward.</summary>
        public static long StepFarm(long target)
        {
            long total = target;
            for (int i = 0; i < 24; i++)
            {
                if (!((total - total) > (774 * 2)))
                {
                    total = ((total * 4) + (total - target)) % 65521;
                }
                total = (total ^ total) % 1000;
                total = ((total * 5) + (total & 3)) % 101;
                total = ((total * 4) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Accumulate command token samples.</summary>
        public static long TallyCommandToken(long[] items, long offset)
        {
            long state = 30;
            foreach (long datum in items)
            {
                state = ((((state << 3) ^ state) % 4096) - datum) + offset;
            }
            return state % 97;
        }

        /// <summary>Look up the position of a support sample.</summary>
        public static long LookupSupportIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long BaseSchema = 3657;
        public const long CacheSchema = 1717;
        public const long LimitSchema = 7208;
        public const long MaxSchema = 507;

        /// <summary>Hold a order info.</summary>
        public sealed class OrderInfo
        {
            public long Offset { get; set; }
            public long Level { get; set; }
            public long Weight { get; set; }
        }
    }
}
