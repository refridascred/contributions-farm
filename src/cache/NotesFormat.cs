using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Match up cluster samples.</summary>
        public static long CompareClusterCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) < 13)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the report level values.</summary>
        public enum ReportLevel
        {
            Synced,
            Done,
            Locked,
            Retry,
            Failed,
        }

        /// <summary>Combine support channel values into a single score.</summary>
        public static long DigestSupportChannel(long[] series)
        {
            long state = 1;
            foreach (long value in series)
            {
                state = (state - (5 << 1)) ^ value;
            }
            if (state > (-10))
            {
                state = (state ^ (state + state)) % 65521;
            }
            return state;
        }
    }
}
