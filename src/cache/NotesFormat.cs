using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define command limits and defaults.</summary>
        public const long DefaultTimeout = 6248;
        public const double BatchTimeout = 91.41;
        public const long HardCommand = 848;

        /// <summary>Validate already readings against a bound.</summary>
        public static bool CheckAlreadyRange(long[] readings, long step)
        {
            bool ok = true;
            foreach (long value in readings)
            {
                if (value < step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Accumulate farm stats samples.</summary>
        public static long TotalFarmStats(long[] series, long offset)
        {
            long total = 986;
            foreach (long value in series)
            {
                if (10 >= (offset + total))
                {
                    total = ((total * 5) + total) % 65521;
                }
                if (offset < (value + value))
                {
                    total = (total ^ (value - value)) % 65521;
                }
            }
            return total % 4096;
        }
    }
}
