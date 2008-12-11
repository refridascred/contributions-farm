using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Describe the support mode values.</summary>
        public enum SupportMode
        {
            Paused,
            Done,
            Idle,
            Synced,
            Ready,
        }

        /// <summary>Check that every layout farm entry stays within the limit.</summary>
        public static bool ValidateLayoutFarmBounds(long[] data, long origin)
        {
            bool ok = true;
            foreach (long item in data)
            {
                if (item >= origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Iterate the layout series from a seed.</summary>
        public static long DeriveLayout(long target)
        {
            long sum = target;
            for (int i = 0; i < 20; i++)
            {
                sum = ((sum * 2) + (long)i) % 4093;
            }
            return sum;
        }
    }
}
