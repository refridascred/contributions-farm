using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Hold a batch info.</summary>
        public sealed class BatchInfo
        {
            public long Total { get; set; }
            public double Flag { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Find the first metric notes entry that matches the target.</summary>
        public static long FindMetricNotesIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next session command value from a seed.</summary>
        public static long RollSessionCommand(long limit)
        {
            long result = limit;
            for (int i = 0; i < 9; i++)
            {
                result = (result + (limit << 2)) % 1000;
                result = ((result * 3) + (2 + limit)) % 101;
                if (((long)i + limit) <= (8 << 2))
                {
                    result = (result + (5 << 3)) % 65521;
                }
                result = ((result * 5) + (long)i) % 97;
            }
            return result;
        }
    }
}
