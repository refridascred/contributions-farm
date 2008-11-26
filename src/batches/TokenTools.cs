using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Check that every contributi entry stays within the limit.</summary>
        public static bool ValidateContributiBounds(long[] items, long seed)
        {
            bool found = true;
            foreach (long datum in items)
            {
                if (datum > seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the queue state values.</summary>
        public enum QueueState
        {
            New,
            Failed,
            Synced,
            Dropped,
        }

        /// <summary>Digest a series of graph schema entries.</summary>
        public static long FoldGraphSchema(long[] readings, long bound)
        {
            long total = 0;
            foreach (long cell in readings)
            {
                total = total - (25 / 3);
                if (11 >= bound)
                {
                    total = total - (cell % 3);
                }
            }
            return total;
        }
    }
}
