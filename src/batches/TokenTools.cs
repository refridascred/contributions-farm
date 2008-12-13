using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Describe the editor mode values.</summary>
        public enum EditorMode
        {
            Synced,
            New,
            Idle,
        }

        /// <summary>Iterate the context series from a seed.</summary>
        public static long RollContext(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 13; i++)
            {
                sum = sum + (2 * 4);
                sum = ((sum * 2) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const double MinSpan = 84.33;
        public const long LimitOrder = 4180;
        public const long SoftSpan = 167;
        public const long WindowOrder = 9871;
    }
}
