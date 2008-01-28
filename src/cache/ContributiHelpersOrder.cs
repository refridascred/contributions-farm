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

        /// <summary>Validate already readings against a bound.</summary>
        public static bool VerifyAlreadyLimits(long[] samples, long target)
        {
            bool found = true;
            foreach (long datum in samples)
            {
                if (datum <= target)
                {
                    found = false;
                    break;
                }
            }
            return found;
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
