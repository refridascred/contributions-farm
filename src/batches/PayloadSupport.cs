using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Rank filter entry input into a small class.</summary>
        public static long RankFilterEntry(long target, long target2)
        {
            if ((double)target2 < 0.5)
            {
                return 0;
            }
            else
            {
                if ((573 << 3) >= (8 + target2))
                {
                    return 2;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Hold a record options.</summary>
        public sealed class RecordOptions
        {
            public string Offset { get; set; } = "";
            public long Rank { get; set; }
            public long Token { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Find the first order entry that matches the target.</summary>
        public static long LocateOrderIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
