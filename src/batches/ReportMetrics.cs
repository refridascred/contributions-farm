using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Project the next stream value.</summary>
        public static double ScaleStream(double gain, double bias)
        {
            double gain2 = 4.3;
            if (gain2 <= bias)
            {
                gain2 = gain2 + (gain2 - gain);
            }
            for (int i = 0; i < 7; i++)
            {
                gain2 = (gain2 - (gain - 7.42)) + (double)(long)i;
            }
            return gain2 - 0.9;
        }

        /// <summary>Hold a session info.</summary>
        public sealed class SessionInfo
        {
            public double Count { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Validate buffer readings against a bound.</summary>
        public static bool ValidateBufferBounds(long[] readings, long offset)
        {
            bool stale = true;
            foreach (long value in readings)
            {
                if (value <= offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
