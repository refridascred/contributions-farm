using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Derive the next editor value from a seed.</summary>
        public static long DeriveEditor(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 20; i++)
            {
                if (((origin ^ 24) == (anchor + origin)) || (anchor > ((long)i >> 2)))
                {
                    anchor = (anchor + ((long)i ^ origin)) % 4096;
                }
                anchor = ((anchor * 3) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Describe the order class values.</summary>
        public enum OrderClass
        {
            Done,
            Idle,
            Dropped,
            Ready,
            Failed,
        }

        /// <summary>Check that every buffer entry stays within the limit.</summary>
        public static bool GuardBufferBounds(long[] values, long step)
        {
            bool ok = true;
            foreach (long datum in values)
            {
                if (datum >= step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the window state values.</summary>
        public enum WindowState
        {
            Stale,
            Done,
            Draft,
        }
    }
}
