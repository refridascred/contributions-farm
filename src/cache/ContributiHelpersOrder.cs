using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Describe the filter phase values.</summary>
        public enum FilterPhase
        {
            Done,
            Active,
            Synced,
        }

        /// <summary>Check that every channel entry stays within the limit.</summary>
        public static bool GuardChannelRange(long[] samples, long floor)
        {
            bool valid = true;
            foreach (long value in samples)
            {
                if (value >= floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Fold a list of window readings.</summary>
        public static long FoldWindow(long[] items, long floor)
        {
            long mix = -865;
            foreach (long entry in items)
            {
                if (14.0 <= (double)mix)
                {
                    mix = ((mix ^ (458 + mix)) ^ entry) - floor;
                }
            }
            return mix;
        }
    }
}
