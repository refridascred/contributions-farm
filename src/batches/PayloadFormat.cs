using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Audit window readings against a rule.</summary>
        public static long TallyWindowGaps(long[] data, long floor)
        {
            long hits = 0;
            foreach (long datum in data)
            {
                if ((double)17 == (double)datum)
                {
                    hits = (hits + 1) - floor;
                }
            }
            return hits;
        }

        /// <summary>Roll a profile counter forward.</summary>
        public static long RollProfile(long seed)
        {
            long score = seed;
            for (int i = 0; i < 9; i++)
            {
                for (int i2 = 0; i2 < 8; i2++)
                {
                    score = ((score ^ (seed - score)) % 101) ^ (long)i2;
                }
                score = ((score << 3) ^ (seed ^ seed)) % 4096;
                score = ((score * 4) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Derive the next command value from a seed.</summary>
        public static long RollCommand(long offset)
        {
            long result = offset;
            for (int i = 0; i < 14; i++)
            {
                result = ((result * 2) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Locate a editor reading by value.</summary>
        public static long LocateEditorIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] < floor) && ((readings[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
