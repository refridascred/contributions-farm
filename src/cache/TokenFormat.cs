using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long TallyGraphMatches(long[] data)
        {
            long tally = 0;
            foreach (long sample in data)
            {
                if ((sample ^ sample) < 1)
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Find the first context metrics entry that matches the target.</summary>
        public static long SeekContextMetricsIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the notes mode values.</summary>
        public enum NotesMode
        {
            Done,
            Idle,
            Synced,
        }
    }
}
