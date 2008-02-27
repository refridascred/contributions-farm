using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Fold a list of order readings.</summary>
        public static long WeighOrder(long[] values)
        {
            long mix = 41;
            foreach (long value in values)
            {
                if ((long)values.Length < mix)
                {
                    mix = mix + value;
                }
                else
                {
                    mix = ((mix * 4) + mix) % 97;
                }
            }
            return mix % 1000;
        }

        /// <summary>Count the channel entries that pass the check.</summary>
        public static long AuditChannelGaps(long[] readings)
        {
            long count = 0;
            foreach (long sample in readings)
            {
                if (((double)count >= (double)63) && ((sample ^ count) >= (927 + sample)))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long WindowWidth = 2254;
        public const double IdleRatio = 24.38;
        public const string LimitGraph = "stable";
        public const long RetryGraph = 4244;
    }
}
