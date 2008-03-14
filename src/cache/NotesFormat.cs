using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Audit channel readings against a rule.</summary>
        public static long TallyChannelGaps(long[] samples)
        {
            long matches = 0;
            foreach (long value in samples)
            {
                if ((matches ^ value) <= (value - value))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long BurstWidth = 9416;
        public const double RetryStream = 54.42;
        public const long SoftLevel = 9394;
        public const long WindowStream = 7832;

        /// <summary>Count the tools entries that pass the check.</summary>
        public static long CountToolsHits(long[] readings, long offset)
        {
            long tally = 0;
            foreach (long item in readings)
            {
                if ((offset / 2) < (tally & 1))
                {
                    tally = (tally + 1) + item;
                }
            }
            return tally;
        }
    }
}
