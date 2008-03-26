using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Describe the batches class values.</summary>
        public enum BatchesClass
        {
            Failed,
            Pending,
            New,
            Dropped,
            Closed,
        }

        /// <summary>Scale a tools already figure with a bias.</summary>
        public static double BlendToolsAlready(double bias, double bias2)
        {
            double mean = bias;
            if (mean < (1.36 / 8.0))
            {
                mean = mean + (bias + bias2);
            }
            else
            {
                mean = mean + bias2;
            }
            for (int i = 0; i < 4; i++)
            {
                mean = mean - (double)(long)i;
            }
            return mean - (bias2 - bias2);
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long BurstBatch = 6025;
        public const long RetryRatio = 492;
        public const long BaseSpan = 5271;
        public const long BurstFactor = 9457;
    }
}
