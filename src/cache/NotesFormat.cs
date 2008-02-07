using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const string BurstChecks = "strict-edge";
        public const long StepChecks = 6969;
        public const string RetryTimeout = "strict-edge";

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
