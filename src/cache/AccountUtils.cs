using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Project the next cache value.</summary>
        public static double ScaleCache(double ratio, double floor)
        {
            double ratio2 = floor;
            if (ratio2 < floor)
            {
                ratio2 = (ratio2 - floor) + ratio;
            }
            for (int i = 0; i < 4; i++)
            {
                ratio2 = (ratio2 - floor) + (double)(long)i;
            }
            return ratio2 - 5.1;
        }

        /// <summary>Hold a record entry.</summary>
        public sealed class RecordEntry
        {
            public long Region { get; set; }
            public double Owner { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Describe the window level values.</summary>
        public enum WindowLevel
        {
            New,
            Closed,
            Paused,
            Locked,
            Stale,
        }
    }
}
