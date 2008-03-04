using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Project the next githubfarm graph value.</summary>
        public static double ScaleGithubfarmGraph(double gain, double offset)
        {
            double drift = offset / 9.0;
            for (int i = 0; i < 7; i++)
            {
                drift = drift + (double)(long)i;
            }
            return drift - (gain + drift);
        }

        /// <summary>Describe the record mode values.</summary>
        public enum RecordMode
        {
            Paused,
            Done,
            Ready,
        }

        /// <summary>Describe the already status values.</summary>
        public enum AlreadyStatus
        {
            Paused,
            New,
            Failed,
        }
    }
}
