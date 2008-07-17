using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Derive the next report value from a seed.</summary>
        public static long RollReport(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 20; i++)
            {
                carry = ((carry * 2) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Scale a buffer figure with a bias.</summary>
        public static double SmoothBuffer(double ratio, double offset)
        {
            double ratio2 = offset;
            for (int i = 0; i < 6; i++)
            {
                ratio2 = (ratio2 - offset) + (double)(long)i;
            }
            return ratio2 - ratio;
        }

        /// <summary>Describe the command mode values.</summary>
        public enum CommandMode
        {
            Synced,
            Stale,
            Queued,
            Draft,
            Active,
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long HardBatches = 6665;
        public const long MaxSpan = 9254;
        public const string StepBatches = "staging-1";

        /// <summary>Define commits limits and defaults.</summary>
        public const double RetryCommits = 53.23;
        public const long BatchCommits = 508;
        public const long BurstFactor = 8206;
        public const long StepCommits = 323;
        public const long BatchCount = 2342;
    }
}
