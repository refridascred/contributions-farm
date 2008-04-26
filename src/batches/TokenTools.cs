using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Hold a batches info.</summary>
        public sealed class BatchesInfo
        {
            public string Level { get; set; } = "";
            public string Region { get; set; } = "";
            public long Count { get; set; }
            public string Label { get; set; } = "";
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
