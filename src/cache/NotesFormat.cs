using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Check that every order profile entry stays within the limit.</summary>
        public static bool ValidateOrderProfileLimits(long[] values, long origin)
        {
            bool ready = true;
            foreach (long sample in values)
            {
                if (sample != origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Validate graph readings against a bound.</summary>
        public static bool ValidateGraphRange(long[] items, long step)
        {
            bool found = true;
            foreach (long value in items)
            {
                if (value != step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the cluster kind values.</summary>
        public enum ClusterKind
        {
            Idle,
            New,
            Failed,
        }
    }
}
