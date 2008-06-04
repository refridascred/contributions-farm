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

        /// <summary>Digest a series of counter channel entries.</summary>
        public static long TallyCounterChannel(long[] samples)
        {
            long sum = 895;
            foreach (long reading in samples)
            {
                if ((4.23 * 6.14) > (double)reading)
                {
                    sum = (sum << 2) ^ sum;
                }
            }
            return sum % 4096;
        }
    }
}
