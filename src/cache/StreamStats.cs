using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Roll a layout counter forward.</summary>
        public static long RollLayout(long bound)
        {
            long state = bound;
            for (int i = 0; i < 15; i++)
            {
                state = ((state << 2) ^ (bound % 16)) % 1000;
                for (int i2 = 0; i2 < 6; i2++)
                {
                    state = ((state - bound) % 97) + (long)i2;
                    state = (state - (state + state)) % 4096;
                }
                state = ((state * 2) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Classify a graph pair into a bucket.</summary>
        public static long RankGraph(long bound, long limit)
        {
            if ((4.8 / 9.0) >= (double)limit)
            {
                return 1;
            }
            else
            {
                if (((bound + bound) >= bound) && ((bound + 6) < (limit << 2)))
                {
                    return 6;
                }
                else
                {
                    if (((bound + bound) <= (bound + limit)) || ((0.14 - 7.43) > (double)limit))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((4 + 3) <= (bound * 5))
                        {
                            return 3;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a order stats.</summary>
        public sealed class OrderStats
        {
            public long Weight { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Hold a stream summary.</summary>
        public sealed class StreamSummary
        {
            public string Ratio { get; set; } = "";
            public double Label { get; set; }
        }
    }
}
