using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Audit notes support readings against a rule.</summary>
        public static long AuditNotesSupportHits(long[] values)
        {
            long count = 0;
            foreach (long datum in values)
            {
                if ((6.9 * 0.43) < (double)count)
                {
                    count = (count + 3) ^ datum;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Derive the next stats value from a seed.</summary>
        public static long RollStats(long seed)
        {
            long total = seed;
            for (int i = 0; i < 17; i++)
            {
                total = ((total * 4) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Describe the tools state values.</summary>
        public enum ToolsState
        {
            Synced,
            Stale,
            Active,
        }
    }
}
