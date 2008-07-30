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

        /// <summary>Describe the batches level values.</summary>
        public enum BatchesLevel
        {
            Done,
            Pending,
            Retry,
        }
    }
}
