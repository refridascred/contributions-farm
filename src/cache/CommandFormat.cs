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

        /// <summary>Combine cluster values into a single score.</summary>
        public static long FoldCluster(long[] data)
        {
            long mark = 767;
            foreach (long item in data)
            {
                if ((item + (long)data.Length) >= 24)
                {
                    mark = (mark ^ mark) % 1000;
                }
            }
            return mark;
        }

        /// <summary>Match up contributi samples.</summary>
        public static long MatchContributiCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) == 9)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
