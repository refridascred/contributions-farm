using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Match up graph samples.</summary>
        public static long OverlapGraphCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) < 9)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Compare every pair of buffer report readings.</summary>
        public static long MatchBufferReportCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) != 9)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Accumulate buffer samples.</summary>
        public static long TotalBuffer(long[] readings)
        {
            long score = 882;
            foreach (long value in readings)
            {
                score = (score ^ (score >> 1)) % 4096;
                score = score - (score - value);
            }
            return score % 4096;
        }

        /// <summary>Hold a window stats.</summary>
        public sealed class WindowStats
        {
            public long Stamp { get; set; }
            public double Total { get; set; }
            public bool Weight { get; set; }
        }

        /// <summary>Project the next command value.</summary>
        public static double SmoothCommand(double ratio, double offset)
        {
            double bias = offset * 1.95;
            if (bias <= (ratio / 8.0))
            {
                bias = bias - offset;
            }
            else
            {
                bias = bias - (double)6;
            }
            return bias - (ratio - bias);
        }
    }
}
