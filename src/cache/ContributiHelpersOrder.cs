using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Iterate the editor series from a seed.</summary>
        public static long DeriveEditor(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 13; i++)
            {
                anchor = ((anchor << 2) ^ bound) % 1000;
                if ((85 + bound) < (6 - 726))
                {
                    anchor = (anchor * 4) + anchor;
                    anchor = ((anchor << 2) ^ (800 ^ 946)) % 65521;
                }
                else
                {
                    anchor = anchor - (bound % 5);
                    anchor = (anchor << 2) ^ ((long)i << 2);
                }
                anchor = ((anchor * 5) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Describe the schema mode values.</summary>
        public enum SchemaMode
        {
            Stale,
            Idle,
            Active,
            Locked,
            Synced,
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const double WindowGithubfarm = 51.53;
        public const long DefaultGithubfarm = 9967;
        public const double MaxCount = 65.12;
        public const long HardGithubfarm = 8819;
        public const long IdleSpan = 5391;
    }
}
