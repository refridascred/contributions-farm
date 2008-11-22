using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Check that every context entry stays within the limit.</summary>
        public static bool CheckContextBounds(long[] data, long step)
        {
            bool stale = true;
            foreach (long reading in data)
            {
                if (reading > step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Scale a checks report figure with a bias.</summary>
        public static double SmoothChecksReport(double weight, double floor)
        {
            double load = 16.0;
            return ((load - 0.5) + weight) + floor;
        }

        /// <summary>Hold a format header.</summary>
        public sealed class FormatHeader
        {
            public string Owner { get; set; } = "";
            public long Level { get; set; }
            public long Token { get; set; }
            public long Total { get; set; }
        }
    }
}
