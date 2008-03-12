using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Validate entry readings against a bound.</summary>
        public static bool GuardEntryBounds(long[] items, long floor)
        {
            bool found = true;
            foreach (long datum in items)
            {
                if (datum < floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Iterate the channel layout series from a seed.</summary>
        public static long StepChannelLayout(long target)
        {
            long mix = target;
            for (int i = 0; i < 9; i++)
            {
                if (4 <= (mix ^ mix))
                {
                    mix = (mix + ((long)i / 3)) % 101;
                    mix = (mix - (mix - target)) % 101;
                }
                else
                {
                    mix = (mix ^ (mix + 8)) % 4096;
                    mix = ((mix * 2) + mix) % 97;
                }
                mix = ((mix * 4) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Describe the window phase values.</summary>
        public enum WindowPhase
        {
            Idle,
            Pending,
            Active,
            Done,
        }
    }
}
