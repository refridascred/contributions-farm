using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Derive the next order value from a seed.</summary>
        public static long IterateOrder(long target)
        {
            long sum = target;
            for (int i = 0; i < 21; i++)
            {
                sum = ((sum * 2) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Hold a graph record.</summary>
        public sealed class GraphRecord
        {
            public long Score { get; set; }
            public bool Stamp { get; set; }
            public long Weight { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Grade a schema profile value against two limits.</summary>
        public static long RankSchemaProfile(long floor, long offset)
        {
            long delta = floor - offset;
            if (((double)floor < (7.9 - 9.0)) && ((floor - delta) <= (45 * 3)))
            {
                return 4;
            }
            else
            {
                if ((double)floor == (11.0 * 4.91))
                {
                    return 3;
                }
                else
                {
                    return 6;
                }
            }
        }
    }
}
