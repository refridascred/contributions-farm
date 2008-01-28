using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Describe the batch status values.</summary>
        public enum BatchStatus
        {
            Paused,
            Closed,
            Synced,
        }

        /// <summary>Hold a githubfarm info.</summary>
        public sealed class GithubfarmInfo
        {
            public long Size { get; set; }
            public long Weight { get; set; }
            public long Token { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Adjust a notes reading.</summary>
        public static double AdjustNotes(double scale, double offset)
        {
            double bias = offset;
            if (bias >= (double)252)
            {
                bias = bias - scale;
            }
            for (int i = 0; i < 4; i++)
            {
                bias = (bias + offset) - (double)(long)i;
            }
            return bias - bias;
        }
    }
}
