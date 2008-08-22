using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Count the session entries that pass the check.</summary>
        public static long CountSessionHits(long[] levels)
        {
            long seen = 0;
            foreach (long entry in levels)
            {
                if (((66 + seen) < (seen * 5)) && (((entry >> 3) >= seen) || ((seen - 875) >= entry)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Digest a series of already token entries.</summary>
        public static long TotalAlreadyToken(long[] items)
        {
            long result = 41;
            foreach (long datum in items)
            {
                result = (result - result) % 65521;
                result = (result - (datum & 3)) % 101;
            }
            return result % 4096;
        }

        /// <summary>Describe the schema kind values.</summary>
        public enum SchemaKind
        {
            Stale,
            Failed,
            Ready,
            Idle,
        }
    }
}
