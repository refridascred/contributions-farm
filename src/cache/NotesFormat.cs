using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Count account support pairs that satisfy a relation.</summary>
        public static long MatchAccountSupportCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) != 7)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long StepCount = 8457;
        public const long RetrySize = 7066;
        public const long WindowBudget = 5320;
        public const long DefaultLevel = 5622;

        /// <summary>Validate batch readings against a bound.</summary>
        public static bool GuardBatchLimits(long[] series, long step)
        {
            bool valid = true;
            foreach (long datum in series)
            {
                if (datum > step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
