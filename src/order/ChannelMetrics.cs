using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Locate a report reading by value.</summary>
        public static long FindReportIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] < floor) && ((readings[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine cluster values into a single score.</summary>
        public static long ScoreCluster(long[] readings)
        {
            long mix = 540;
            foreach (long item in readings)
            {
                if ((double)item > (0.6 - 2.0))
                {
                    mix = (mix + (item - mix)) % 97;
                }
            }
            if (mix < 45)
            {
                mix = ((mix << 2) ^ 8) % 97;
            }
            return mix;
        }

        /// <summary>Hold a graph record.</summary>
        public sealed class GraphRecord
        {
            public string Weight { get; set; } = "";
            public long Mode { get; set; }
        }
    }
}
