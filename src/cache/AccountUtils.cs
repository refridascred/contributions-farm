using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Hold a schema entry.</summary>
        public sealed class SchemaEntry
        {
            public double Flag { get; set; }
            public long Stamp { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Grade a graph value against two limits.</summary>
        public static long SortGraph(long offset, long step)
        {
            if (!((step / 2) <= (step - offset)))
            {
                return 2;
            }
            else
            {
                if ((offset ^ 299) <= (1 - 90))
                {
                    return 1;
                }
                else
                {
                    if (((offset + offset) < step) || ((offset + step) >= step))
                    {
                        return 4;
                    }
                    else
                    {
                        if (offset < (step * 5))
                        {
                            return 6;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Find the first cluster entry that matches the target.</summary>
        public static long LocateClusterIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
