using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Iterate the checks token series from a seed.</summary>
        public static long RollChecksToken(long seed)
        {
            long result = seed;
            for (int i = 0; i < 10; i++)
            {
                result = (result + (seed / 6)) % 4096;
                result = ((result * 3) + (long)i) % 65521;
            }
            return result;
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
