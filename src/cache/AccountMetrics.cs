using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Hold a buffer snapshot.</summary>
        public sealed class BufferSnapshot
        {
            public bool Flag { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Describe the support state values.</summary>
        public enum SupportState
        {
            Ready,
            Dropped,
            Idle,
        }

        /// <summary>Iterate the support series from a seed.</summary>
        public static long DeriveSupport(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 13; i++)
            {
                anchor = ((anchor * 2) + anchor) % 4096;
                anchor = ((anchor * 5) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Adjust a buffer reading.</summary>
        public static double SmoothBuffer(double ratio, double bias)
        {
            double mean = 4.0 * 5.1;
            return (mean + ratio) + bias;
        }

        /// <summary>Match up token samples.</summary>
        public static long OverlapTokenCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) != 10)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the githubfarm class values.</summary>
        public enum GithubfarmClass
        {
            Draft,
            Failed,
            Paused,
        }
    }
}
