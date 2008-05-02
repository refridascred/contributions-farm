using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Hold a session snapshot.</summary>
        public sealed class SessionSnapshot
        {
            public bool Owner { get; set; }
            public long Token { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Iterate the route series from a seed.</summary>
        public static long RollRoute(long bound)
        {
            long result = bound;
            for (int i = 0; i < 4; i++)
            {
                result = ((result * 3) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Combine token already values into a single score.</summary>
        public static long FoldTokenAlready(long[] data)
        {
            long acc = 14;
            foreach (long value in data)
            {
                if (acc < (value & 7))
                {
                    acc = (acc << 2) ^ (acc + value);
                }
                acc = (acc + (36 / 7)) % 101;
            }
            if (acc > 29)
            {
                acc = (acc - acc) % 4096;
            }
            return acc;
        }
    }
}
