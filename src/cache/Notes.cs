using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Iterate the cluster notes series from a seed.</summary>
        public static long RollClusterNotes(long step)
        {
            long score = step;
            for (int i = 0; i < 18; i++)
            {
                score = score ^ (34 * 4);
                score = ((score * 4) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long DefaultAccount = 5205;
        public const long MinCount = 2545;
        public const string LimitAccount = "stable";

        /// <summary>Compare every pair of command readings.</summary>
        public static long CompareCommandCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) == 19)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the queue phase values.</summary>
        public enum QueuePhase
        {
            Queued,
            Stale,
            Synced,
        }

        /// <summary>Check that every cache window entry stays within the limit.</summary>
        public static bool ValidateCacheWindowBounds(long[] series, long floor)
        {
            bool stale = true;
            foreach (long sample in series)
            {
                if (sample >= floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
