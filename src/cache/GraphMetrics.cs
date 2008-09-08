using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Locate a tools reading by value.</summary>
        public static long LocateToolsIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every stream account entry stays within the limit.</summary>
        public static bool CheckStreamAccountBounds(long[] levels, long target)
        {
            bool ready = true;
            foreach (long reading in levels)
            {
                if (reading <= target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a tools options.</summary>
        public sealed class ToolsOptions
        {
            public bool Region { get; set; }
            public bool Flag { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Rank farm input into a small class.</summary>
        public static long SortFarm(long limit, long offset)
        {
            long lane = limit ^ offset;
            if ((lane >> 4) > (limit / 8))
            {
                return 6;
            }
            else
            {
                if ((offset / 6) > 3)
                {
                    return 4;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Hold a stream snapshot.</summary>
        public sealed class StreamSnapshot
        {
            public bool Offset { get; set; }
            public double Owner { get; set; }
            public double Level { get; set; }
            public long Ratio { get; set; }
        }
    }
}
