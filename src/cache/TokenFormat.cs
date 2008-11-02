using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Hold a schema record.</summary>
        public sealed class SchemaRecord
        {
            public double Label { get; set; }
            public bool Size { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Classify a command entry pair into a bucket.</summary>
        public static long SortCommandEntry(long bound, long seed)
        {
            long step = bound ^ seed;
            if ((seed - seed) < (bound - step))
            {
                return 5;
            }
            else
            {
                if (((step * 3) < (49 - seed)) && (4.7 > (double)bound))
                {
                    return 4;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long MaxToken = 2057;
        public const long IdleToken = 6135;
        public const long SoftDepth = 2537;
        public const double SoftWidth = 32.21;
    }
}
