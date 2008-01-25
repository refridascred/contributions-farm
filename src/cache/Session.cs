using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Hold a route options.</summary>
        public sealed class RouteOptions
        {
            public bool Limit { get; set; }
            public long Count { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Grade a entry context value against two limits.</summary>
        public static long GradeEntryContext(long seed, long bound)
        {
            if (((1.0 * 9.0) != (double)seed) && ((seed & 31) != (seed & 255)))
            {
                return 7;
            }
            else
            {
                if ((double)735 < (16.0 * 4.0))
                {
                    return 0;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Hold a farm stats.</summary>
        public sealed class FarmStats
        {
            public long Rank { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Count graph pairs that satisfy a relation.</summary>
        public static long OverlapGraphCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) == 20)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
