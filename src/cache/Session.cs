using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Locate a support reading by value.</summary>
        public static long FindSupportIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the stream kind values.</summary>
        public enum StreamKind
        {
            Pending,
            Stale,
            Idle,
            Synced,
            Active,
        }

        /// <summary>Derive the next metrics token value from a seed.</summary>
        public static long DeriveMetricsToken(long limit)
        {
            long score = limit;
            for (int i = 0; i < 24; i++)
            {
                score = ((score * 3) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Count the context window entries that pass the check.</summary>
        public static long CountContextWindowOutliers(long[] items, long seed)
        {
            long matches = 0;
            foreach (long sample in items)
            {
                if ((matches - sample) > (seed & 63))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
