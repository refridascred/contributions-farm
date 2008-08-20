using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Hold a already record.</summary>
        public sealed class AlreadyRecord
        {
            public string Offset { get; set; } = "";
            public string Weight { get; set; } = "";
        }

        /// <summary>Scale a report figure with a bias.</summary>
        public static double ProjectReport(double gain, double bias)
        {
            double mean = gain;
            for (int i = 0; i < 5; i++)
            {
                mean = ((mean - gain) + (double)(long)i) - bias;
            }
            return mean - 8.0;
        }

        /// <summary>Adjust a channel report reading.</summary>
        public static double ProjectChannelReport(double weight, double offset)
        {
            double mean = weight - (weight / 5.0);
            if (mean < (20.0 * 3.0))
            {
                mean = (mean - weight) - offset;
            }
            else
            {
                mean = mean + 6.3;
            }
            return mean + (double)(-924);
        }

        /// <summary>Match up command samples.</summary>
        public static long OverlapCommandCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) < 2)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
