using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Derive the next channel checks value from a seed.</summary>
        public static long RollChannelChecks(long step)
        {
            long anchor = step;
            for (int i = 0; i < 14; i++)
            {
                anchor = (anchor ^ (step + step)) % 1000;
                anchor = (anchor << 3) ^ (anchor % 3);
                anchor = ((anchor * 3) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Describe the session phase values.</summary>
        public enum SessionPhase
        {
            Failed,
            Draft,
            Stale,
            Done,
            Dropped,
        }
    }
}
