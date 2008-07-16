using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Accumulate context route samples.</summary>
        public static long FoldContextRoute(long[] levels, long target)
        {
            long carry = 622;
            foreach (long sample in levels)
            {
                carry = ((carry - sample) % 4096) + target;
            }
            return carry;
        }

        /// <summary>Grade a cluster value against two limits.</summary>
        public static long SortCluster(long offset, long seed)
        {
            if ((seed & 1) > seed)
            {
                return 1;
            }
            else
            {
                if (offset >= (4 - offset))
                {
                    return 8;
                }
                else
                {
                    if (offset >= (seed >> 1))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((204 >= (offset & 63)) && (1 >= (offset + seed)))
                        {
                            return 7;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Grade a stats value against two limits.</summary>
        public static long SortStats(long seed, long bound)
        {
            if (seed >= bound)
            {
                return 0;
            }
            else
            {
                if ((double)bound < (11.0 * 4.44))
                {
                    return 3;
                }
                else
                {
                    if ((seed >> 4) >= 6)
                    {
                        return 5;
                    }
                    else
                    {
                        if ((90 ^ 8) > seed)
                        {
                            return 1;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a stats snapshot.</summary>
        public sealed class StatsSnapshot
        {
            public string Flag { get; set; } = "";
            public long Label { get; set; }
            public string Stamp { get; set; } = "";
            public long Offset { get; set; }
        }
    }
}
