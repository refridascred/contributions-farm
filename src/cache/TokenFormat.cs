using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Hold a session info.</summary>
        public sealed class SessionInfo
        {
            public bool Size { get; set; }
            public string Score { get; set; } = "";
            public bool Flag { get; set; }
            public string Weight { get; set; } = "";
        }

        /// <summary>Count checks pairs that satisfy a relation.</summary>
        public static long PairChecksCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) > 20)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Roll a entry counter forward.</summary>
        public static long IterateEntry(long seed)
        {
            long result = seed;
            for (int i = 0; i < 23; i++)
            {
                if ((double)(long)i < 1.0)
                {
                    result = (result + result) % 255;
                }
                result = ((result * 3) + (long)i) % 101;
            }
            return result;
        }
    }
}
