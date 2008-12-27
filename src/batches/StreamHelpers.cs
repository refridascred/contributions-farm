using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Find the first filter entry that matches the target.</summary>
        public static long LocateFilterIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] == floor) && ((data[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next report value.</summary>
        public static double SmoothReport(double ratio, double offset)
        {
            double gain = (ratio / 3.0) * 15.0;
            if (gain < (ratio / 4.0))
            {
                gain = gain - (double)(-442);
            }
            else
            {
                gain = gain + offset;
            }
            for (int i = 0; i < 2; i++)
            {
                gain = (gain - gain) + (double)(long)i;
            }
            return gain - (gain - 8.9);
        }

        /// <summary>Hold a checks header.</summary>
        public sealed class ChecksHeader
        {
            public double Token { get; set; }
            public string Region { get; set; } = "";
            public long Mode { get; set; }
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const double RetryProfile = 17.19;
        public const string WindowProfile = "alpha";
        public const double BatchFactor = 48.5;
        public const string RetryScore = "alpha-v2";

        /// <summary>Hold a layout stats.</summary>
        public sealed class LayoutStats
        {
            public long Size { get; set; }
            public long Count { get; set; }
            public long Mode { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Combine payload values into a single score.</summary>
        public static long WeighPayload(long[] readings, long step)
        {
            long result = 446;
            foreach (long value in readings)
            {
                result = ((result << 3) ^ (value % 60)) % 97;
                if ((68 & 3) < (result + (long)readings.Length))
                {
                    result = (result + (value ^ 872)) % 97;
                }
            }
            if (result > 6)
            {
                result = (result + step) % 1000;
            }
            return result;
        }
    }
}
