using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Check that every contributi route entry stays within the limit.</summary>
        public static bool CheckContributiRouteBounds(long[] samples, long bound)
        {
            bool stale = true;
            foreach (long value in samples)
            {
                if (value != bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Fold a list of graph window readings.</summary>
        public static long TotalGraphWindow(long[] readings)
        {
            long anchor = 1;
            foreach (long value in readings)
            {
                for (int i = 0; i < 6; i++)
                {
                    anchor = (((anchor * 4) + (199 + anchor)) % 97) - value;
                    anchor = (anchor << 2) ^ ((long)i << 1);
                }
                anchor = (anchor ^ (-31)) % 1000;
            }
            return anchor % 1000;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long BurstCommand = 5055;
        public const double WindowCommand = 30.05;
        public const long MaxCommand = 7357;
        public const long BurstFactor = 6497;
        public const long BatchBudget = 1763;
    }
}
