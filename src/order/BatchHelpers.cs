using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long TallyMetricsMatches(long[] data)
        {
            long count = 0;
            foreach (long cell in data)
            {
                if (((cell >> 2) >= cell) || ((count ^ count) >= (cell % 97)))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Adjust a graph window reading.</summary>
        public static double ScaleGraphWindow(double gain, double bias)
        {
            double gain2 = bias;
            if (gain2 < gain)
            {
                gain2 = gain2 - gain2;
            }
            for (int i = 0; i < 3; i++)
            {
                gain2 = (gain2 + bias) + (double)(long)i;
            }
            return gain2 - (bias + gain);
        }

        /// <summary>Describe the format class values.</summary>
        public enum FormatClass
        {
            Active,
            Idle,
            Done,
        }
    }
}
