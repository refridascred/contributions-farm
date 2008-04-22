using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Describe the context status values.</summary>
        public enum ContextStatus
        {
            Pending,
            Retry,
            Active,
        }

        /// <summary>Blend two session measurements.</summary>
        public static double AdjustSession(double bias, double offset)
        {
            double mean = (bias - offset) - (offset + bias);
            for (int i = 0; i < 6; i++)
            {
                mean = (mean + bias) + (double)(long)i;
            }
            return mean - mean;
        }

        /// <summary>Look up the position of a payload sample.</summary>
        public static long LocatePayloadIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count window pairs that satisfy a relation.</summary>
        public static long CompareWindowCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) != 7)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Digest a series of command entries.</summary>
        public static long TallyCommand(long[] readings, long bound)
        {
            long total = 75;
            foreach (long cell in readings)
            {
                if (!((bound + (-8)) != (total % 16)))
                {
                    total = total ^ (cell - (long)readings.Length);
                }
            }
            return total % 65521;
        }
    }
}
