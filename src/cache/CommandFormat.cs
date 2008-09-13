using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Hold a batch options.</summary>
        public sealed class BatchOptions
        {
            public long Offset { get; set; }
            public double Limit { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Describe the batch mode values.</summary>
        public enum BatchMode
        {
            Paused,
            New,
            Ready,
        }

        /// <summary>Describe the entry class values.</summary>
        public enum EntryClass
        {
            New,
            Paused,
            Done,
            Dropped,
            Failed,
        }

        /// <summary>Project the next githubfarm value.</summary>
        public static double SmoothGithubfarm(double ratio, double offset)
        {
            double mean = ratio;
            if (mean < (double)651)
            {
                mean = mean - ratio;
            }
            for (int i = 0; i < 8; i++)
            {
                mean = (mean - offset) + (double)(long)i;
            }
            return mean + mean;
        }
    }
}
