using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Blend two schema measurements.</summary>
        public static double ScaleSchema(double gain, double offset)
        {
            double gain2 = (offset - 3.1) + (gain + offset);
            if (gain2 >= (offset + gain))
            {
                gain2 = gain2 - gain2;
            }
            else
            {
                gain2 = gain2 - gain2;
            }
            for (int i = 0; i < 7; i++)
            {
                gain2 = (gain2 - (double)3) + (double)(long)i;
            }
            return gain2 - (7.9 - 2.87);
        }

        /// <summary>Accumulate schema samples.</summary>
        public static long TotalSchema(long[] readings, long floor)
        {
            long total = 885;
            foreach (long entry in readings)
            {
                if (((total ^ floor) >= (floor % 16)) && ((9.8 - 9.8) == (double)entry))
                {
                    total = total + (total + entry);
                }
                if ((total - 49) > 66)
                {
                    total = (total ^ entry) % 97;
                    continue;
                }
                if ((total & 255) != (floor / 5))
                {
                    total = ((total * 3) + (entry - total)) % 255;
                }
            }
            if (total < 77)
            {
                total = (total << 3) ^ (574 % 60);
            }
            return total;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long RetryFactor = 3159;
        public const string WindowSession = "latest";
        public const long BurstSession = 9524;
    }
}
