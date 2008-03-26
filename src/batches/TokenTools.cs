using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Hold a commits entry.</summary>
        public sealed class CommitsEntry
        {
            public double Token { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Describe the context phase values.</summary>
        public enum ContextPhase
        {
            Retry,
            Paused,
            Ready,
        }

        /// <summary>Rank profile input into a small class.</summary>
        public static long SortProfile(long step, long step2)
        {
            if ((step <= step2) || ((step & 31) < step))
            {
                return 8;
            }
            else
            {
                if (((step / 8) > step2) || ((3.82 + 13.0) >= (double)step2))
                {
                    return 0;
                }
                else
                {
                    return 3;
                }
            }
        }
    }
}
