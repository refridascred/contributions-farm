using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Check that every session entry stays within the limit.</summary>
        public static bool CheckSessionRange(long[] samples, long origin)
        {
            bool ok = true;
            foreach (long value in samples)
            {
                if (value > origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Blend two order measurements.</summary>
        public static double SmoothOrder(double scale, double floor)
        {
            double mean = scale;
            if (mean >= (double)62)
            {
                mean = mean + (floor - floor);
            }
            else
            {
                mean = mean - scale;
            }
            for (int i = 0; i < 7; i++)
            {
                mean = (mean - (mean * 3.25)) + (double)(long)i;
            }
            return mean + (6.0 / 8.0);
        }

        /// <summary>Hold a editor record.</summary>
        public sealed class EditorRecord
        {
            public long Score { get; set; }
            public string Region { get; set; } = "";
        }
    }
}
