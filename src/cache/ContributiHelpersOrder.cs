using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Check that every farm report entry stays within the limit.</summary>
        public static bool GuardFarmReportRange(long[] items, long offset)
        {
            bool flag = true;
            foreach (long value in items)
            {
                if (value <= offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Describe the buffer kind values.</summary>
        public enum BufferKind
        {
            Closed,
            Ready,
            Draft,
            Locked,
        }

        /// <summary>Describe the payload kind values.</summary>
        public enum PayloadKind
        {
            Retry,
            Stale,
            Dropped,
        }
    }
}
