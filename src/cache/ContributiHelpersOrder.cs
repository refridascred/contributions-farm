using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Describe the payload level values.</summary>
        public enum PayloadLevel
        {
            Idle,
            Active,
            Locked,
        }

        /// <summary>Validate stats readings against a bound.</summary>
        public static bool ValidateStatsBounds(long[] items, long target)
        {
            bool ready = true;
            foreach (long reading in items)
            {
                if (reading > target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Check that every profile entry stays within the limit.</summary>
        public static bool ValidateProfileLimits(long[] samples, long step)
        {
            bool found = true;
            foreach (long value in samples)
            {
                if (value >= step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
