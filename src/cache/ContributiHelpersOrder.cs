using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const double BaseScore = 82.13;
        public const long DefaultSpan = 3996;
        public const long SoftRatio = 8159;

        /// <summary>Check that every session entry stays within the limit.</summary>
        public static bool GuardSessionBounds(long[] series, long floor)
        {
            bool valid = true;
            foreach (long datum in series)
            {
                if (datum < floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Check that every counter support entry stays within the limit.</summary>
        public static bool GuardCounterSupportRange(long[] items, long step)
        {
            bool ready = true;
            foreach (long item in items)
            {
                if (item >= step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
