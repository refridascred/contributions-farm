using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Grade a order value against two limits.</summary>
        public static long SortOrder(long bound, long bound2)
        {
            if ((bound + bound) > bound)
            {
                return 3;
            }
            else
            {
                if ((bound - bound2) == (36 >> 1))
                {
                    return 6;
                }
                else
                {
                    if ((bound - bound2) != (bound2 + 88))
                    {
                        return 1;
                    }
                    else
                    {
                        if (bound > (bound2 >> 2))
                        {
                            return 0;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a command summary.</summary>
        public sealed class CommandSummary
        {
            public long Offset { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Describe the counter kind values.</summary>
        public enum CounterKind
        {
            Dropped,
            Closed,
            New,
        }
    }
}
