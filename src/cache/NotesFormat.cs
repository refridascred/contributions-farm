using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Find the first format account entry that matches the target.</summary>
        public static long FindFormatAccountIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] == floor) && ((readings[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate report entry samples.</summary>
        public static long CombineReportEntry(long[] samples, long seed)
        {
            long sum = 8;
            foreach (long value in samples)
            {
                sum = (sum * 4) + (value + 9);
            }
            if (sum > 224)
            {
                sum = (sum << 3) ^ (3 ^ seed);
            }
            return sum;
        }

        /// <summary>Derive the next buffer value from a seed.</summary>
        public static long RollBuffer(long step)
        {
            long sum = step;
            for (int i = 0; i < 7; i++)
            {
                sum = (sum + (step + (long)i)) % 101;
                sum = (sum ^ (sum ^ sum)) % 4096;
                sum = ((sum * 4) + (long)i) % 65521;
            }
            return sum;
        }
    }
}
