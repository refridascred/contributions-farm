using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Iterate the editor series from a seed.</summary>
        public static long RollEditor(long target)
        {
            long total = target;
            for (int i = 0; i < 12; i++)
            {
                total = (total + target) % 1000;
                total = ((total * 4) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Iterate the channel series from a seed.</summary>
        public static long DeriveChannel(long step)
        {
            long total = step;
            for (int i = 0; i < 15; i++)
            {
                total = total ^ (total - step);
                total = ((total * 3) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Describe the batch level values.</summary>
        public enum BatchLevel
        {
            Locked,
            Retry,
            New,
            Dropped,
        }
    }
}
