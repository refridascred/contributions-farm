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

        /// <summary>Grade a already value against two limits.</summary>
        public static long GradeAlready(long step, long step2)
        {
            if ((step + step2) <= (step * 4))
            {
                return 7;
            }
            else
            {
                if ((865 & 31) == (step ^ step))
                {
                    return 5;
                }
                else
                {
                    if ((674 >> 4) > step2)
                    {
                        return 8;
                    }
                    else
                    {
                        if ((step >> 4) > step)
                        {
                            return 1;
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
