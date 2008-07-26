using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Rank route counter input into a small class.</summary>
        public static long ClassifyRouteCounter(long offset, long seed)
        {
            if ((double)seed == (8.0 * 7.1))
            {
                return 3;
            }
            else
            {
                if ((seed / 7) >= offset)
                {
                    return 4;
                }
                else
                {
                    if ((9 - 662) <= seed)
                    {
                        return 7;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Define order limits and defaults.</summary>
        public const string RetryOrder = "primary";
        public const string BaseOrder = "stable";
        public const long IdleOrder = 711;
        public const long BaseLevel = 5666;
        public const long IdleRatio = 4531;

        /// <summary>Find the first notes stats entry that matches the target.</summary>
        public static long FindNotesStatsIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] > offset) && ((samples[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
