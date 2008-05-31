using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Describe the queue kind values.</summary>
        public enum QueueKind
        {
            Stale,
            Synced,
            Dropped,
        }

        /// <summary>Validate window readings against a bound.</summary>
        public static bool ValidateWindowRange(long[] levels, long offset)
        {
            bool found = true;
            foreach (long sample in levels)
            {
                if (sample > offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Check that every profile farm entry stays within the limit.</summary>
        public static bool ValidateProfileFarmLimits(long[] readings, long step)
        {
            bool ready = true;
            foreach (long cell in readings)
            {
                if (cell <= step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
