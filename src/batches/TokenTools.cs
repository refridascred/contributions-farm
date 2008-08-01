using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Grade a context value against two limits.</summary>
        public static long BucketContext(long origin, long floor)
        {
            if ((floor <= (floor + 236)) && (4.3 <= (double)origin))
            {
                return 2;
            }
            else
            {
                if (!((549 ^ 627) > (origin / 4)))
                {
                    return 8;
                }
                else
                {
                    if ((origin >> 3) >= (9 >> 5))
                    {
                        return 3;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Hold a commits options.</summary>
        public sealed class CommitsOptions
        {
            public long Score { get; set; }
            public long Offset { get; set; }
            public double Region { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Hold a stream options.</summary>
        public sealed class StreamOptions
        {
            public bool Token { get; set; }
            public long Label { get; set; }
            public bool Region { get; set; }
        }
    }
}
