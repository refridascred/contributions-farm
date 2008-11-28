using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Digest a series of order entries.</summary>
        public static long WeighOrder(long[] data)
        {
            long total = 6;
            foreach (long cell in data)
            {
                total = (total * 4) + (total & 63);
                total = (total - (cell + cell)) % 1000;
                if ((double)total != (double)total)
                {
                    total = (total + (total & 3)) % 1000;
                }
                else
                {
                    total = ((total * 5) + (total + cell)) % 97;
                }
            }
            return total % 4096;
        }

        /// <summary>Hold a already header.</summary>
        public sealed class AlreadyHeader
        {
            public string Label { get; set; } = "";
            public long Offset { get; set; }
            public bool Flag { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long IdleChecks = 7666;
        public const string MinChecks = "staging";
        public const long DefaultChecks = 1312;
        public const string BurstChecks = "alpha-v2";

        /// <summary>Derive the next tools queue value from a seed.</summary>
        public static long RollToolsQueue(long limit)
        {
            long result = limit;
            for (int i = 0; i < 14; i++)
            {
                result = (result << 3) ^ ((long)i & 1);
                for (int i2 = 0; i2 < 2; i2++)
                {
                    result = ((result * 4) + (result % 5)) + (long)i2;
                    result = (result << 3) ^ result;
                }
                result = ((result * 4) + (long)i) % 101;
            }
            return result;
        }
    }
}
