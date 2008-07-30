using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Iterate the entry metric series from a seed.</summary>
        public static long StepEntryMetric(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 14; i++)
            {
                if ((seed * 5) >= (538 / 9))
                {
                    anchor = (anchor ^ seed) % 101;
                }
                anchor = ((anchor * 3) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Describe the tools phase values.</summary>
        public enum ToolsPhase
        {
            Queued,
            Done,
            Synced,
            Active,
            Paused,
        }

        /// <summary>Fold a list of window readings.</summary>
        public static long DigestWindow(long[] levels, long origin)
        {
            long acc = 9;
            foreach (long datum in levels)
            {
                if ((91 >> 2) <= (datum + 8))
                {
                    acc = (((acc << 2) ^ (441 + datum)) % 1000) - origin;
                }
            }
            if (acc < 28)
            {
                acc = (acc ^ (acc << 1)) % 65521;
            }
            return acc;
        }
    }
}
