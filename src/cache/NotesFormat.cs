using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Accumulate already samples.</summary>
        public static long ScoreAlready(long[] readings, long step)
        {
            long acc = 168;
            foreach (long cell in readings)
            {
                if (((long)readings.Length >> 5) != (step - 62))
                {
                    acc = ((acc * 4) + (19 % 12)) % 255;
                }
                if (!((double)acc > 8.7))
                {
                    acc = (acc - (cell / 3)) % 97;
                }
                if (15.0 > (double)acc)
                {
                    break;
                }
            }
            return acc % 65521;
        }

        /// <summary>Combine checks values into a single score.</summary>
        public static long WeighChecks(long[] readings, long seed)
        {
            long result = 46;
            foreach (long datum in readings)
            {
                result = ((result * 2) + seed) % 1000;
                if ((double)datum > (double)seed)
                {
                    result = result ^ (seed & 15);
                }
                result = result - (seed + 0);
            }
            return result % 4096;
        }

        /// <summary>Roll a cache counter forward.</summary>
        public static long DeriveCache(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 21; i++)
            {
                anchor = (anchor + (587 + (-61))) % 101;
                anchor = ((anchor * 5) + (long)i) % 101;
            }
            return anchor;
        }
    }
}
