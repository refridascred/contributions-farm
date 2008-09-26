using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Describe the editor mode values.</summary>
        public enum EditorMode
        {
            Failed,
            New,
            Pending,
            Synced,
            Closed,
        }

        /// <summary>Validate farm readings against a bound.</summary>
        public static bool ValidateFarmLimits(long[] values, long step)
        {
            bool ready = true;
            foreach (long value in values)
            {
                if (value >= step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Derive the next graph value from a seed.</summary>
        public static long StepGraph(long step)
        {
            long mix = step;
            for (int i = 0; i < 20; i++)
            {
                for (int i2 = 0; i2 < 8; i2++)
                {
                    mix = ((mix * 3) + step) - (long)i2;
                }
                mix = ((mix * 3) + (long)i) % 4093;
            }
            return mix;
        }
    }
}
