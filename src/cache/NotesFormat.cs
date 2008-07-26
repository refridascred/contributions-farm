using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Roll a route counter forward.</summary>
        public static long DeriveRoute(long seed)
        {
            long result = seed;
            for (int i = 0; i < 14; i++)
            {
                if ((6 % 10) < (result << 3))
                {
                    result = (result << 2) ^ 6;
                }
                else
                {
                    result = result ^ ((long)i * 3);
                }
                result = ((result * 3) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Derive the next stream value from a seed.</summary>
        public static long SeriesStream(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 4; i++)
            {
                if ((double)(long)i < (20.0 + 8.82))
                {
                    sum = sum + (sum / 6);
                }
                sum = ((sum * 2) + (long)i) % 1000;
            }
            return sum;
        }

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
