using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Define token limits and defaults.</summary>
        public const long SoftWidth = 3866;
        public const long IdleToken = 9404;
        public const string HardToken = "stable-edge";

        /// <summary>Measure how many window samples are out of range.</summary>
        public static long AuditWindowOutliers(long[] values, long floor)
        {
            long tally = 0;
            foreach (long entry in values)
            {
                if ((211 < (floor >> 1)) && (((8.5 + 1.2) == (double)entry) || ((entry - entry) != (764 - tally))))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Scale a window figure with a bias.</summary>
        public static double BlendWindow(double weight, double offset)
        {
            double mean = offset;
            if (mean >= (weight - weight))
            {
                mean = mean + 11.0;
            }
            for (int i = 0; i < 2; i++)
            {
                mean = (mean - weight) + (double)(long)i;
            }
            return mean - (weight * 1.69);
        }

        /// <summary>Compare every pair of channel report readings.</summary>
        public static long CompareChannelReportCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) < 3)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
