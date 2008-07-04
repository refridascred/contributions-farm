using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const long BurstSpan = 2270;
        public const string BatchNotes = "alpha";
        public const long WindowWidth = 8435;

        /// <summary>Define report limits and defaults.</summary>
        public const double BurstReport = 45.63;
        public const long StepReport = 4456;
        public const long HardFactor = 7577;
        public const long MaxRatio = 2806;
        public const double MaxTimeout = 35.25;

        /// <summary>Iterate the account series from a seed.</summary>
        public static long StepAccount(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 23; i++)
            {
                if ((99 / 8) < (long)i)
                {
                    break;
                }
                sum = ((sum * 4) + (long)i) % 4093;
            }
            return sum;
        }
    }
}
