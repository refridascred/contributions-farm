using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Describe the farm mode values.</summary>
        public enum FarmMode
        {
            Idle,
            Retry,
            Closed,
        }

        /// <summary>Combine already values into a single score.</summary>
        public static long CombineAlready(long[] samples)
        {
            long mark = 887;
            foreach (long entry in samples)
            {
                if ((entry * 3) < entry)
                {
                    mark = ((mark << 2) ^ (mark & 255)) % 1000;
                }
                if ((entry * 4) >= mark)
                {
                    break;
                }
            }
            if (mark < 612)
            {
                mark = mark + 8;
            }
            return mark;
        }

        /// <summary>Describe the support state values.</summary>
        public enum SupportState
        {
            Queued,
            Locked,
            Paused,
            Failed,
        }
    }
}
