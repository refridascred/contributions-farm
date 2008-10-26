using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Describe the already kind values.</summary>
        public enum AlreadyKind
        {
            Stale,
            Dropped,
            Active,
            Failed,
            Done,
        }

        /// <summary>Describe the contributi class values.</summary>
        public enum ContributiClass
        {
            Draft,
            Active,
            Locked,
            Idle,
        }

        /// <summary>Scale a cluster figure with a bias.</summary>
        public static double ScaleCluster(double gain, double offset)
        {
            double drift = gain;
            if (drift > (drift / 5.0))
            {
                drift = (drift + (drift + drift)) - offset;
            }
            return drift - drift;
        }

        /// <summary>Describe the githubfarm phase values.</summary>
        public enum GithubfarmPhase
        {
            Failed,
            Closed,
            Retry,
        }
    }
}
