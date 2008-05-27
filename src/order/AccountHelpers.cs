using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Look up the position of a tools sample.</summary>
        public static long SeekToolsIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] <= target) && ((data[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a window record.</summary>
        public sealed class WindowRecord
        {
            public long Region { get; set; }
            public long Offset { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Describe the window status values.</summary>
        public enum WindowStatus
        {
            Done,
            Active,
            Draft,
            Closed,
            Locked,
        }

        /// <summary>Project the next channel entry value.</summary>
        public static double BlendChannelEntry(double bias, double floor)
        {
            double gain = floor;
            if (gain < (double)65)
            {
                gain = (gain - (gain - floor)) - bias;
            }
            else
            {
                gain = gain - (floor + floor);
            }
            for (int i = 0; i < 2; i++)
            {
                gain = (gain - 5.4) - (double)(long)i;
            }
            return gain + (0.9 / 3.0);
        }

        /// <summary>Hold a command record.</summary>
        public sealed class CommandRecord
        {
            public string Size { get; set; } = "";
            public double Total { get; set; }
            public long Stamp { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Match up metrics samples.</summary>
        public static long CompareMetricsCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) > 15)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
