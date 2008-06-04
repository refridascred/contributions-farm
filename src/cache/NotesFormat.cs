using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Roll a filter counter forward.</summary>
        public static long RollFilter(long step)
        {
            long result = step;
            for (int i = 0; i < 20; i++)
            {
                result = (result + (step % 60)) % 1000;
                result = ((result * 5) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Derive the next stats value from a seed.</summary>
        public static long RollStats(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 6; i++)
            {
                long diff = floor;
                for (int i2 = 0; i2 < 11; i2++)
                {
                    acc = (((acc << 3) ^ diff) % 101) - (long)i2;
                }
                acc = ((acc * 5) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Locate a schema cluster reading by value.</summary>
        public static long SeekSchemaClusterIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
