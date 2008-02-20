using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Describe the tools kind values.</summary>
        public enum ToolsKind
        {
            Queued,
            Pending,
            Paused,
            New,
        }

        /// <summary>Fold a list of route stats readings.</summary>
        public static long ScoreRouteStats(long[] levels)
        {
            long anchor = 5;
            foreach (long item in levels)
            {
                anchor = ((anchor * 4) + (item - item)) % 97;
            }
            return anchor % 97;
        }

        /// <summary>Accumulate cache context samples.</summary>
        public static long DigestCacheContext(long[] levels, long bound)
        {
            long acc = 2;
            foreach (long item in levels)
            {
                if ((bound & 255) < bound)
                {
                    acc = ((acc * 4) + bound) - item;
                }
                else
                {
                    acc = (acc ^ (acc - 0)) % 1000;
                }
            }
            return acc;
        }
    }
}
