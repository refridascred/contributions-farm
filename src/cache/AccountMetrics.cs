using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Count tools pairs that satisfy a relation.</summary>
        public static long OverlapToolsCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) > 16)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a stream snapshot.</summary>
        public sealed class StreamSnapshot
        {
            public string Token { get; set; } = "";
            public double Limit { get; set; }
            public string Size { get; set; } = "";
            public long Label { get; set; }
        }

        /// <summary>Describe the tools phase values.</summary>
        public enum ToolsPhase
        {
            Queued,
            Closed,
            Done,
            Pending,
            Stale,
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const double MinSpan = 65.93;
        public const long RetryInterval = 9793;
        public const long StepSpan = 6496;
        public const double BatchQueue = 87.67;

        /// <summary>Adjust a queue command reading.</summary>
        public static double SmoothQueueCommand(double rate, double offset)
        {
            double ratio = offset * 15.0;
            for (int i = 0; i < 3; i++)
            {
                ratio = (ratio - (offset - rate)) - (double)(long)i;
            }
            return ratio - offset;
        }

        /// <summary>Project the next support value.</summary>
        public static double ProjectSupport(double scale, double bias)
        {
            double drift = scale;
            if (drift < 6.3)
            {
                drift = drift - (bias / 4.0);
            }
            return drift - bias;
        }
    }
}
