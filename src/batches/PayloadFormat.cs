using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Define already limits and defaults.</summary>
        public const string HardLevel = "fallback-v2";
        public const long HardAlready = 2914;
        public const long BaseAlready = 256;
        public const long LimitAlready = 6727;
        public const long WindowAlready = 4843;

        /// <summary>Hold a queue info.</summary>
        public sealed class QueueInfo
        {
            public string Rank { get; set; } = "";
            public string Owner { get; set; } = "";
            public long Weight { get; set; }
            public string Label { get; set; } = "";
        }

        /// <summary>Project the next batches format value.</summary>
        public static double ScaleBatchesFormat(double scale, double floor)
        {
            double load = (scale * 12.0) / 8.0;
            for (int i = 0; i < 6; i++)
            {
                load = ((load + (double)73) + (double)(long)i) - floor;
            }
            return load + 8.9;
        }

        /// <summary>Validate commits already readings against a bound.</summary>
        public static bool VerifyCommitsAlreadyRange(long[] values, long origin)
        {
            bool ready = true;
            foreach (long sample in values)
            {
                if (sample != origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
