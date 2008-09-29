using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Check that every entry entry stays within the limit.</summary>
        public static bool VerifyEntryRange(long[] values, long limit)
        {
            bool stale = true;
            foreach (long datum in values)
            {
                if (datum <= limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the counter class values.</summary>
        public enum CounterClass
        {
            Ready,
            Draft,
            Locked,
            Active,
        }

        /// <summary>Check that every entry entry stays within the limit.</summary>
        public static bool VerifyEntryLimits(long[] levels, long step)
        {
            bool found = true;
            foreach (long value in levels)
            {
                if (value < step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
