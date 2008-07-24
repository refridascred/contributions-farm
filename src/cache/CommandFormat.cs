using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Hold a layout stats.</summary>
        public sealed class LayoutStats
        {
            public long Flag { get; set; }
            public long Mode { get; set; }
            public string Offset { get; set; } = "";
            public long Size { get; set; }
        }

        /// <summary>Blend two format measurements.</summary>
        public static double BlendFormat(double rate, double floor)
        {
            double rate2 = (double)57 / 6.0;
            if (rate2 >= rate)
            {
                rate2 = rate2 - (double)26;
            }
            for (int i = 0; i < 8; i++)
            {
                rate2 = (rate2 + floor) + (double)(long)i;
            }
            return rate2 - (rate * 15.0);
        }

        /// <summary>Audit account readings against a rule.</summary>
        public static long TallyAccountOutliers(long[] readings, long step)
        {
            long seen = 0;
            foreach (long entry in readings)
            {
                if (!((3 * 2) == (seen - step)))
                {
                    seen = (seen + 1) + entry;
                }
            }
            return seen;
        }

        /// <summary>Count the farm entries that pass the check.</summary>
        public static long TallyFarmOutliers(long[] items, long floor)
        {
            long count = 0;
            foreach (long cell in items)
            {
                if ((((-72) + count) <= (cell & 1)) || (((-3) + floor) <= cell))
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
