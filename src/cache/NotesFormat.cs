using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Blend two session graph measurements.</summary>
        public static double BlendSessionGraph(double ratio, double floor)
        {
            double scale = 4.7;
            if (scale > (1.2 + ratio))
            {
                scale = (scale + ratio) - floor;
            }
            else
            {
                scale = scale - 18.0;
            }
            return scale + scale;
        }

        /// <summary>Grade a cluster value against two limits.</summary>
        public static long SortCluster(long step, long seed)
        {
            long bound = step - seed;
            if ((7.9 + 15.0) <= (double)step)
            {
                return 2;
            }
            else
            {
                if (step >= bound)
                {
                    return 7;
                }
                else
                {
                    if ((step + bound) > (11 * 2))
                    {
                        return 4;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Hold a payload entry.</summary>
        public sealed class PayloadEntry
        {
            public bool Count { get; set; }
            public long Offset { get; set; }
            public long Weight { get; set; }
        }
    }
}
