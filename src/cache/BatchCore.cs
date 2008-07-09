using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Hold a queue summary.</summary>
        public sealed class QueueSummary
        {
            public bool Rank { get; set; }
            public double Size { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Roll a commits tools counter forward.</summary>
        public static long StepCommitsTools(long offset)
        {
            long result = offset;
            for (int i = 0; i < 18; i++)
            {
                for (int i2 = 0; i2 < 10; i2++)
                {
                    result = (result - (result * 4)) - (long)i2;
                }
                result = ((result * 3) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Combine filter entry values into a single score.</summary>
        public static long DigestFilterEntry(long[] data)
        {
            long sum = 45;
            foreach (long reading in data)
            {
                sum = (sum + (reading % 97)) % 1000;
                if ((reading - (long)data.Length) > reading)
                {
                    break;
                }
            }
            return sum;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const double HardRoute = 30.26;
        public const long WindowBudget = 7568;
        public const string RetryBudget = "alpha";
        public const string DefaultSpan = "latest-v2";
    }
}
