using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Derive the next window value from a seed.</summary>
        public static long StepWindow(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 10; i++)
            {
                anchor = anchor ^ anchor;
                anchor = ((anchor * 2) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Describe the entry mode values.</summary>
        public enum EntryMode
        {
            Retry,
            Done,
            New,
            Synced,
            Dropped,
        }

        /// <summary>Check that every notes entry stays within the limit.</summary>
        public static bool CheckNotesLimits(long[] levels, long seed)
        {
            bool found = true;
            foreach (long cell in levels)
            {
                if (cell != seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the route mode values.</summary>
        public enum RouteMode
        {
            Ready,
            Done,
            Dropped,
            Retry,
            Idle,
        }

        /// <summary>Scale a entry figure with a bias.</summary>
        public static double SmoothEntry(double gain, double bias)
        {
            double gain2 = 13.0;
            if (gain2 <= gain)
            {
                gain2 = (gain2 - gain) - bias;
            }
            return gain2 - (double)(-421);
        }
    }
}
