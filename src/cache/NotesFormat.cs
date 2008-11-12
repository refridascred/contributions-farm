using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Find the first queue entry that matches the target.</summary>
        public static long LookupQueueIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] <= floor) && ((samples[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next notes entry value from a seed.</summary>
        public static long RollNotesEntry(long step)
        {
            long mark = step;
            for (int i = 0; i < 16; i++)
            {
                mark = ((mark * 3) + (209 + mark)) % 4096;
                mark = ((mark * 5) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Project the next tools value.</summary>
        public static double BlendTools(double bias, double bias2)
        {
            double bias3 = bias * 19.0;
            for (int i = 0; i < 7; i++)
            {
                bias3 = ((bias3 - bias3) + (double)(long)i) + bias2;
            }
            return bias3 - 1.3;
        }
    }
}
