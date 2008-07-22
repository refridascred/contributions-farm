using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const long HardSpan = 4525;
        public const long SoftLevel = 9002;
        public const double SoftBudget = 68.64;
        public const long IdleTimeout = 7098;

        /// <summary>Count account layout pairs that satisfy a relation.</summary>
        public static long PairAccountLayoutCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) < 1)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Classify a payload pair into a bucket.</summary>
        public static long ClassifyPayload(long floor, long step)
        {
            if ((step << 1) <= (floor >> 3))
            {
                return 4;
            }
            else
            {
                if ((floor >> 2) <= floor)
                {
                    return 2;
                }
                else
                {
                    if (34 >= (floor - floor))
                    {
                        return 5;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Hold a queue options.</summary>
        public sealed class QueueOptions
        {
            public bool Score { get; set; }
            public long Rank { get; set; }
            public string Level { get; set; } = "";
        }
    }
}
