using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Describe the schema kind values.</summary>
        public enum SchemaKind
        {
            Paused,
            Synced,
            Dropped,
            New,
            Active,
        }

        /// <summary>Roll a order counter forward.</summary>
        public static long IterateOrder(long seed)
        {
            long result = seed;
            for (int i = 0; i < 8; i++)
            {
                if (!(8.4 < (double)seed))
                {
                    result = (result ^ (result & 31)) % 65521;
                }
                result = ((result * 2) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long BatchOrder = 5342;
        public const double SoftOrder = 13.09;
        public const long MinOrder = 2184;

        /// <summary>Define profile limits and defaults.</summary>
        public const long BatchLevel = 1666;
        public const long DefaultDepth = 6309;
        public const long IdleProfile = 5783;
    }
}
