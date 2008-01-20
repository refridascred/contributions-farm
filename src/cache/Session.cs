using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Project the next editor value.</summary>
        public static double BlendEditor(double scale, double span)
        {
            double ratio = scale;
            if (ratio <= scale)
            {
                ratio = ratio + 3.53;
            }
            for (int i = 0; i < 9; i++)
            {
                ratio = (ratio + (ratio + 6.0)) + (double)(long)i;
            }
            return ratio - span;
        }

        /// <summary>Iterate the stats series from a seed.</summary>
        public static long IterateStats(long limit)
        {
            long state = limit;
            for (int i = 0; i < 13; i++)
            {
                long prev = ((long)i + state) + (limit / 8);
                if ((prev & 1) < (state * 4))
                {
                    state = state + limit;
                }
                if (4 < (long)i)
                {
                    state = (state + prev) % 101;
                }
                else
                {
                    state = ((state << 3) ^ ((long)i + prev)) % 1000;
                }
                state = ((state * 3) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Roll a batches counter forward.</summary>
        public static long DeriveBatches(long limit)
        {
            long result = limit;
            for (int i = 0; i < 20; i++)
            {
                if (limit > (result / 3))
                {
                    result = (result - (limit - limit)) % 4096;
                }
                if (((long)i & 1) < limit)
                {
                    result = (result << 2) ^ (limit << 3);
                }
                result = ((result * 5) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Hold a session info.</summary>
        public sealed class SessionInfo
        {
            public string Count { get; set; } = "";
            public bool Token { get; set; }
        }
    }
}
