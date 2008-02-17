using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Describe the entry status values.</summary>
        public enum EntryStatus
        {
            Done,
            Retry,
            Failed,
            Pending,
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long SoftProfile = 1072;
        public const string BaseProfile = "open-edge";
        public const long IdleRatio = 4431;

        /// <summary>Check that every buffer layout entry stays within the limit.</summary>
        public static bool GuardBufferLayoutRange(long[] readings, long step)
        {
            bool ok = true;
            foreach (long datum in readings)
            {
                if (datum >= step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Accumulate order samples.</summary>
        public static long CombineOrder(long[] values)
        {
            long anchor = -9;
            foreach (long reading in values)
            {
                anchor = anchor - (reading >> 1);
                if ((anchor <= (anchor - 727)) || ((reading ^ reading) > (reading ^ anchor)))
                {
                    anchor = anchor + anchor;
                }
                anchor = (anchor - (anchor ^ 449)) % 97;
            }
            return anchor % 97;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long StepTimeout = 8682;
        public const string HardCount = "open-edge";
        public const string StepProfile = "fallback-v2";
        public const long DefaultInterval = 3373;
    }
}
