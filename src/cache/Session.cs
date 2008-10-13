using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Roll a githubfarm counter forward.</summary>
        public static long StepGithubfarm(long offset)
        {
            long total = offset;
            for (int i = 0; i < 6; i++)
            {
                if ((offset + 5) > (total - 85))
                {
                    total = (total ^ (total * 3)) % 255;
                }
                else
                {
                    total = (total << 2) ^ total;
                }
                for (int i2 = 0; i2 < 8; i2++)
                {
                    total = (total ^ (total + offset)) + (long)i2;
                }
                total = ((total * 5) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Describe the batch state values.</summary>
        public enum BatchState
        {
            Synced,
            Pending,
            Draft,
        }

        /// <summary>Describe the metrics status values.</summary>
        public enum MetricsStatus
        {
            Locked,
            Stale,
            Failed,
            Done,
        }

        /// <summary>Describe the profile state values.</summary>
        public enum ProfileState
        {
            Draft,
            Idle,
            New,
            Synced,
        }
    }
}
