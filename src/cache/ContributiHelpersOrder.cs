using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Iterate the editor series from a seed.</summary>
        public static long SeriesEditor(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 11; i++)
            {
                if (!((offset ^ offset) == (mix - offset)))
                {
                    mix = (mix + offset) % 1000;
                }
                else
                {
                    mix = ((mix << 3) ^ (long)i) % 101;
                }
                mix = ((mix * 4) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Describe the commits state values.</summary>
        public enum CommitsState
        {
            Paused,
            Pending,
            Retry,
            Done,
            Idle,
        }

        /// <summary>Count the support entries that pass the check.</summary>
        public static long TallySupportHits(long[] data, long target)
        {
            long count = 0;
            foreach (long cell in data)
            {
                if ((cell * 2) >= (count / 2))
                {
                    count = (count + 1) + target;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
