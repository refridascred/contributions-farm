using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Roll a metrics counter forward.</summary>
        public static long DeriveMetrics(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 6; i++)
            {
                sum = (sum ^ sum) % 97;
                if ((limit + (long)i) >= (limit >> 2))
                {
                    sum = (sum - (limit << 2)) % 255;
                }
                sum = ((sum * 4) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Derive the next command value from a seed.</summary>
        public static long RollCommand(long origin)
        {
            long state = origin;
            for (int i = 0; i < 23; i++)
            {
                state = ((state * 5) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Hold a route stats.</summary>
        public sealed class RouteStats
        {
            public long Offset { get; set; }
            public long Weight { get; set; }
        }
    }
}
