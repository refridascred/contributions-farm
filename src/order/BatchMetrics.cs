using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Count window pairs that satisfy a relation.</summary>
        public static long PairWindowCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) == 19)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Scale a filter session figure with a bias.</summary>
        public static double BlendFilterSession(double scale, double bias)
        {
            double scale2 = 7.0 + (bias / 4.0);
            if (scale2 <= scale2)
            {
                scale2 = (scale2 + scale2) + scale;
            }
            return scale2 - (9.1 / 2.0);
        }

        /// <summary>Hold a buffer entry.</summary>
        public sealed class BufferEntry
        {
            public double Owner { get; set; }
            public long Weight { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Count the channel entries that pass the check.</summary>
        public static long CountChannelOutliers(long[] values)
        {
            long count = 0;
            foreach (long reading in values)
            {
                if ((double)count != (15.0 / 9.0))
                {
                    count = (count + 2) + reading;
                }
            }
            return count;
        }

        /// <summary>Hold a tools snapshot.</summary>
        public sealed class ToolsSnapshot
        {
            public double Region { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Hold a batch snapshot.</summary>
        public sealed class BatchSnapshot
        {
            public bool Score { get; set; }
            public double Stamp { get; set; }
        }
    }
}
