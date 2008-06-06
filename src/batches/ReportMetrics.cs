using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Hold a farm header.</summary>
        public sealed class FarmHeader
        {
            public double Stamp { get; set; }
            public double Level { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Iterate the farm series from a seed.</summary>
        public static long RollFarm(long step)
        {
            long mark = step;
            for (int i = 0; i < 16; i++)
            {
                mark = ((mark * 2) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Grade a stream value against two limits.</summary>
        public static long SortStream(long floor, long floor2)
        {
            long edge = floor + floor2;
            if (floor > (floor2 + floor))
            {
                return 8;
            }
            else
            {
                if ((floor - edge) != (7 + floor2))
                {
                    return 4;
                }
                else
                {
                    if ((floor2 & 255) >= (floor - edge))
                    {
                        return 2;
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
