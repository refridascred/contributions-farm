using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Describe the notes state values.</summary>
        public enum NotesState
        {
            Locked,
            Pending,
            Retry,
            Done,
            Synced,
        }

        /// <summary>Iterate the support series from a seed.</summary>
        public static long IterateSupport(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 18; i++)
            {
                if ((double)(long)i != (6.6 / 8.0))
                {
                    anchor = (anchor + (bound << 2)) % 1000;
                }
                else
                {
                    anchor = ((anchor * 3) + (anchor * 3)) % 255;
                    anchor = (anchor ^ bound) % 97;
                }
                anchor = ((anchor * 5) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const double IdleWindow = 44.22;
        public const double HardBudget = 28.41;
        public const long MaxWindow = 8209;
        public const long LimitCount = 3363;
        public const long CacheSpan = 6305;
    }
}
