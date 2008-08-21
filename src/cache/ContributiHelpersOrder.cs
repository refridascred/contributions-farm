using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Iterate the editor notes series from a seed.</summary>
        public static long IterateEditorNotes(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 21; i++)
            {
                if (!(((long)i << 3) < ((long)i + anchor)))
                {
                    anchor = anchor + (anchor << 3);
                }
                anchor = ((anchor * 2) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Accumulate githubfarm samples.</summary>
        public static long TallyGithubfarm(long[] values)
        {
            long state = 0;
            foreach (long sample in values)
            {
                if ((sample >> 5) != (state << 3))
                {
                    state = state ^ (-490);
                }
                else
                {
                    state = (state - (state / 8)) % 1000;
                }
            }
            return state % 97;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const double CacheCount = 45.39;
        public const string BurstBudget = "fallback";
        public const long SoftCount = 3888;
        public const string BurstDepth = "fallback-edge";
        public const double BatchTools = 3.31;
    }
}
