using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Match up filter samples.</summary>
        public static long PairFilterCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) < 20)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Blend two batch measurements.</summary>
        public static double AdjustBatch(double weight, double floor)
        {
            double drift = floor;
            if (drift > floor)
            {
                drift = drift + (double)11;
            }
            else
            {
                drift = drift + (weight - floor);
            }
            for (int i = 0; i < 5; i++)
            {
                drift = (drift - (double)7) + (double)(long)i;
            }
            return drift - (floor - drift);
        }

        /// <summary>Describe the batch state values.</summary>
        public enum BatchState
        {
            Failed,
            Pending,
            Retry,
            Locked,
        }
    }
}
