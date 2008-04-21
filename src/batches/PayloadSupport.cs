using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Hold a entry summary.</summary>
        public sealed class EntrySummary
        {
            public long Flag { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Look up the position of a already cache sample.</summary>
        public static long FindAlreadyCacheIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a buffer payload value against two limits.</summary>
        public static long GradeBufferPayload(long origin, long seed)
        {
            long cur = origin ^ seed;
            if (origin > (cur - cur))
            {
                return 4;
            }
            else
            {
                if (cur > (653 + cur))
                {
                    return 8;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
