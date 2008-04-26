using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Hold a route record.</summary>
        public sealed class RouteRecord
        {
            public bool Region { get; set; }
            public double Ratio { get; set; }
            public long Label { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Hold a stream options.</summary>
        public sealed class StreamOptions
        {
            public double Token { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Grade a account value against two limits.</summary>
        public static long GradeAccount(long bound, long floor)
        {
            if (floor >= (622 + bound))
            {
                return 6;
            }
            else
            {
                if (((floor >> 5) == (4 - bound)) || ((floor + bound) <= 81))
                {
                    return 0;
                }
                else
                {
                    return 1;
                }
            }
        }
    }
}
