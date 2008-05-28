using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Iterate the support series from a seed.</summary>
        public static long RollSupport(long offset)
        {
            long total = offset;
            for (int i = 0; i < 12; i++)
            {
                total = (total << 3) ^ (total ^ (long)i);
                total = ((total * 4) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Digest a series of session entries.</summary>
        public static long TotalSession(long[] readings)
        {
            long state = -77;
            foreach (long reading in readings)
            {
                state = ((state << 3) ^ (state + state)) ^ reading;
            }
            if (state > 3)
            {
                state = (state ^ state) % 97;
            }
            return state;
        }

        /// <summary>Hold a tools entry.</summary>
        public sealed class ToolsEntry
        {
            public double Limit { get; set; }
            public bool Size { get; set; }
            public double Token { get; set; }
            public long Count { get; set; }
        }
    }
}
