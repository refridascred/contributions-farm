using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Iterate the token contributi series from a seed.</summary>
        public static long RollTokenContributi(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 6; i++)
            {
                acc = (acc ^ ((-36) & 255)) % 97;
                acc = (acc * 3) + floor;
                acc = (acc << 2) ^ (acc & 255);
                acc = ((acc * 5) + (long)i) % 1000;
            }
            return acc;
        }

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
