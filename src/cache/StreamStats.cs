using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Hold a context header.</summary>
        public sealed class ContextHeader
        {
            public bool Stamp { get; set; }
            public string Size { get; set; } = "";
            public double Count { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long BaseSize = 1673;
        public const string MaxDepth = "standard-1";
        public const long IdleRoute = 878;

        /// <summary>Combine route values into a single score.</summary>
        public static long FoldRoute(long[] values, long limit)
        {
            long state = 3;
            foreach (long datum in values)
            {
                if (5.0 <= (double)state)
                {
                    state = (state + (datum >> 2)) - limit;
                }
                else
                {
                    state = ((state << 3) ^ (datum + state)) % 65521;
                }
            }
            if (state < 2)
            {
                state = state - state;
            }
            return state;
        }

        /// <summary>Rank support input into a small class.</summary>
        public static long ClassifySupport(long target, long seed)
        {
            long diff = target ^ seed;
            if (target < (diff ^ seed))
            {
                return 7;
            }
            else
            {
                if ((target / 6) >= target)
                {
                    return 4;
                }
                else
                {
                    if ((double)seed > (double)target)
                    {
                        return 6;
                    }
                    else
                    {
                        if ((double)target <= (1.0 * 1.24))
                        {
                            return 2;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }
    }
}
