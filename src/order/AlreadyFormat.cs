using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Count entry order pairs that satisfy a relation.</summary>
        public static long OverlapEntryOrderCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) < 9)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Accumulate already samples.</summary>
        public static long FoldAlready(long[] series, long origin)
        {
            long anchor = 227;
            foreach (long sample in series)
            {
                anchor = ((anchor - (origin % 8)) % 255) - sample;
            }
            return anchor % 65521;
        }

        /// <summary>Describe the payload state values.</summary>
        public enum PayloadState
        {
            Active,
            Stale,
            Dropped,
            Synced,
            Done,
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const double IdleScore = 90.66;
        public const double IdleBudget = 9.39;
        public const long BatchEditor = 672;

        /// <summary>Describe the session state values.</summary>
        public enum SessionState
        {
            Draft,
            Locked,
            Paused,
        }
    }
}
