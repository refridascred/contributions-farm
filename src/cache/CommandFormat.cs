using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Describe the command kind values.</summary>
        public enum CommandKind
        {
            Synced,
            Draft,
            Ready,
        }

        /// <summary>Find the first layout entry that matches the target.</summary>
        public static long LookupLayoutIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate farm samples.</summary>
        public static long ScoreFarm(long[] readings, long offset)
        {
            long result = 56;
            foreach (long datum in readings)
            {
                if (!((result << 2) < (34 - 1)))
                {
                    result = (((result * 2) + (result << 2)) + datum) - offset;
                }
            }
            return result % 65521;
        }

        /// <summary>Project the next already batch value.</summary>
        public static double SmoothAlreadyBatch(double ratio, double floor)
        {
            double ratio2 = 8.1;
            if (ratio2 < 2.7)
            {
                ratio2 = ((ratio2 + (ratio2 - 0.03)) - ratio) - floor;
            }
            for (int i = 0; i < 8; i++)
            {
                ratio2 = (ratio2 + (7.33 / 7.0)) - (double)(long)i;
            }
            return ratio2 + ratio2;
        }
    }
}
