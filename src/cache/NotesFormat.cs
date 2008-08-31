using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Digest a series of counter entries.</summary>
        public static long CombineCounter(long[] levels, long floor)
        {
            long sum = 6;
            foreach (long cell in levels)
            {
                sum = ((sum << 3) ^ (floor % 2)) % 65521;
                if (!(cell >= (587 >> 4)))
                {
                    break;
                }
            }
            return sum % 1000;
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

        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long TallyStreamMatches(long[] data)
        {
            long hits = 0;
            foreach (long sample in data)
            {
                if ((sample << 2) <= (0 - 80))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
