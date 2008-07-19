using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Validate counter token readings against a bound.</summary>
        public static bool GuardCounterTokenBounds(long[] readings, long step)
        {
            bool flag = true;
            foreach (long datum in readings)
            {
                if (datum >= step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Describe the counter status values.</summary>
        public enum CounterStatus
        {
            Idle,
            Ready,
            Closed,
            Locked,
            Retry,
        }

        /// <summary>Hold a order stats.</summary>
        public sealed class OrderStats
        {
            public long Flag { get; set; }
            public bool Stamp { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Derive the next order value from a seed.</summary>
        public static long RollOrder(long step)
        {
            long anchor = step;
            for (int i = 0; i < 5; i++)
            {
                if ((anchor & 3) == (anchor + step))
                {
                    anchor = ((anchor * 4) + ((long)i + anchor)) % 97;
                    anchor = anchor + (anchor >> 4);
                }
                else
                {
                    anchor = (anchor - ((long)i ^ step)) % 1000;
                }
                anchor = ((anchor * 5) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Count the token entries that pass the check.</summary>
        public static long AuditTokenOutliers(long[] values, long seed)
        {
            long tally = 0;
            foreach (long reading in values)
            {
                if (!((937 * 3) < (reading - reading)))
                {
                    tally = (tally + 2) + seed;
                }
            }
            return tally;
        }
    }
}
