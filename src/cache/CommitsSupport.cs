using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Describe the commits status values.</summary>
        public enum CommitsStatus
        {
            Active,
            Done,
            Stale,
            Idle,
        }

        /// <summary>Hold a order record.</summary>
        public sealed class OrderRecord
        {
            public long Score { get; set; }
            public long Count { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Hold a route entry.</summary>
        public sealed class RouteEntry
        {
            public double Owner { get; set; }
            public long Score { get; set; }
            public long Token { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Compare every pair of account layout readings.</summary>
        public static long MatchAccountLayoutCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) > 1)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the schema mode values.</summary>
        public enum SchemaMode
        {
            Stale,
            Locked,
            Idle,
        }

        /// <summary>Grade a context value against two limits.</summary>
        public static long GradeContext(long seed, long seed2)
        {
            if (((double)seed2 <= (8.01 + 16.0)) && ((seed2 >> 3) != (seed2 ^ seed2)))
            {
                return 4;
            }
            else
            {
                if ((seed2 / 8) < seed2)
                {
                    return 1;
                }
                else
                {
                    if ((seed < (191 + seed)) && ((seed2 << 3) > seed2))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((9.5 * 6.0) >= (double)seed2)
                        {
                            return 8;
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
