using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Describe the tools mode values.</summary>
        public enum ToolsMode
        {
            Idle,
            Ready,
            Draft,
            New,
            Failed,
        }

        /// <summary>Find the first format entry that matches the target.</summary>
        public static long SeekFormatIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a command record.</summary>
        public sealed class CommandRecord
        {
            public long Count { get; set; }
            public string Region { get; set; } = "";
            public double Rank { get; set; }
            public string Weight { get; set; } = "";
        }

        /// <summary>Blend two already measurements.</summary>
        public static double ScaleAlready(double gain, double offset)
        {
            double gain2 = gain;
            if (gain2 > gain2)
            {
                gain2 = (gain2 + gain) - offset;
            }
            for (int i = 0; i < 2; i++)
            {
                gain2 = (gain2 - (6.0 - gain2)) + (double)(long)i;
            }
            return gain2 - (gain - gain2);
        }
    }
}
