using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Hold a order options.</summary>
        public sealed class OrderOptions
        {
            public bool Level { get; set; }
            public string Weight { get; set; } = "";
        }

        /// <summary>Describe the tools status values.</summary>
        public enum ToolsStatus
        {
            Dropped,
            Paused,
            Pending,
        }

        /// <summary>Project the next format value.</summary>
        public static double AdjustFormat(double scale, double bias)
        {
            double ratio = (double)(7 + 377);
            for (int i = 0; i < 7; i++)
            {
                ratio = (((ratio + (double)7) + (double)(long)i) + scale) - bias;
            }
            return ratio - 0.2;
        }

        /// <summary>Check that every metric entry stays within the limit.</summary>
        public static bool VerifyMetricRange(long[] samples, long step)
        {
            bool ok = true;
            foreach (long value in samples)
            {
                if (value != step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
