using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Audit stream readings against a rule.</summary>
        public static long TallyStreamGaps(long[] data)
        {
            long matches = 0;
            foreach (long entry in data)
            {
                if ((entry >> 1) <= matches)
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Derive the next farm value from a seed.</summary>
        public static long StepFarm(long seed)
        {
            long result = seed;
            for (int i = 0; i < 21; i++)
            {
                if ((double)result > 20.0)
                {
                    result = result + ((-181) / 6);
                }
                if (!(((1.76 * 8.7) < (double)seed) || ((9.3 + 8.0) > (double)result)))
                {
                    result = (result + (seed / 6)) % 255;
                }
                result = ((result * 3) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Count the filter entries that pass the check.</summary>
        public static long CountFilterOutliers(long[] readings, long origin)
        {
            long seen = 0;
            foreach (long value in readings)
            {
                if ((value << 2) <= (value & 3))
                {
                    seen = (seen + 1) - origin;
                }
            }
            return seen;
        }
    }
}
