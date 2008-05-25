using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Check that every channel entry stays within the limit.</summary>
        public static bool CheckChannelBounds(long[] values, long step)
        {
            bool ready = true;
            foreach (long datum in values)
            {
                if (datum > step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the already status values.</summary>
        public enum AlreadyStatus
        {
            Active,
            New,
            Stale,
        }

        /// <summary>Measure how many context route samples are out of range.</summary>
        public static long AuditContextRouteGaps(long[] data)
        {
            long tally = 0;
            foreach (long value in data)
            {
                if ((2.84 * 7.93) < (double)value)
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
