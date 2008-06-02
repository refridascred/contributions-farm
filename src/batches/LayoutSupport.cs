using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const double MaxLevel = 29.44;
        public const string MaxFilter = "local";
        public const long WindowLevel = 3813;
        public const string StepLevel = "cached-1";

        /// <summary>Define notes limits and defaults.</summary>
        public const string DefaultNotes = "standard";
        public const long HardInterval = 5497;
        public const double LimitBudget = 69.21;
        public const double MinFactor = 61.67;

        /// <summary>Describe the window mode values.</summary>
        public enum WindowMode
        {
            Idle,
            Synced,
            Locked,
        }

        /// <summary>Check that every channel order entry stays within the limit.</summary>
        public static bool VerifyChannelOrderRange(long[] samples, long bound)
        {
            bool ready = true;
            foreach (long cell in samples)
            {
                if (cell < bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long MeasureGraphMatches(long[] items, long bound)
        {
            long tally = 0;
            foreach (long reading in items)
            {
                if (((double)bound <= (double)tally) || ((tally - reading) < (bound >> 5)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
