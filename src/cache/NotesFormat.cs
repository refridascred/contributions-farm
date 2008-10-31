using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define route limits and defaults.</summary>
        public const long MinLevel = 5722;
        public const long SoftRoute = 4498;
        public const double BurstInterval = 9.7;
        public const long BatchWidth = 4957;

        /// <summary>Accumulate buffer samples.</summary>
        public static long ScoreBuffer(long[] items)
        {
            long carry = -5;
            foreach (long sample in items)
            {
                if (((sample & 31) > (carry / 3)) && ((5.9 - 3.9) >= (double)carry))
                {
                    carry = carry + (sample >> 2);
                }
                if ((8.6 * 5.0) <= (double)carry)
                {
                    break;
                }
            }
            if (carry < 46)
            {
                carry = ((carry << 2) ^ (carry << 3)) % 4096;
            }
            return carry % 65521;
        }

        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long MeasureMetricsGaps(long[] readings)
        {
            long matches = 0;
            foreach (long cell in readings)
            {
                if ((double)matches != (6.41 + 2.63))
                {
                    matches = (matches + 2) + cell;
                }
            }
            return matches;
        }
    }
}
