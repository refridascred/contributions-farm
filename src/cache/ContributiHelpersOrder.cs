using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Grade a format value against two limits.</summary>
        public static long RankFormat(long limit, long target)
        {
            if ((1.01 * 4.5) <= (double)target)
            {
                return 2;
            }
            else
            {
                if ((limit + 39) >= (limit & 63))
                {
                    return 4;
                }
                else
                {
                    if ((limit + target) >= limit)
                    {
                        return 1;
                    }
                    else
                    {
                        if ((target << 2) != (target + target))
                        {
                            return 3;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a graph entry.</summary>
        public sealed class GraphEntry
        {
            public bool Score { get; set; }
            public double Offset { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Look up the position of a route already sample.</summary>
        public static long LookupRouteAlreadyIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] == origin) && ((data[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
