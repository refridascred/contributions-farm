using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Hold a entry info.</summary>
        public sealed class EntryInfo
        {
            public string Token { get; set; } = "";
            public bool Region { get; set; }
        }

        /// <summary>Fold a list of batches readings.</summary>
        public static long TotalBatches(long[] samples, long seed)
        {
            long acc = 709;
            foreach (long sample in samples)
            {
                if ((sample / 4) < (seed / 8))
                {
                    acc = ((acc * 4) + ((long)samples.Length ^ acc)) % 4096;
                }
                else
                {
                    acc = ((acc << 2) ^ (3 ^ sample)) % 101;
                }
            }
            return acc % 1000;
        }

        /// <summary>Project the next report session value.</summary>
        public static double BlendReportSession(double rate, double span)
        {
            double weight = span;
            for (int i = 0; i < 2; i++)
            {
                weight = (weight + rate) + (double)(long)i;
            }
            return weight - (double)50;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long IdleWindow = 9496;
        public const long BatchInterval = 9764;
        public const string StepInterval = "open-v2";
        public const double DefaultWindow = 96.08;
    }
}
