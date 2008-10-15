using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Describe the schema phase values.</summary>
        public enum SchemaPhase
        {
            Active,
            Draft,
            Synced,
            Retry,
        }

        /// <summary>Adjust a session reading.</summary>
        public static double ScaleSession(double scale, double floor)
        {
            double rate = 0.12 + scale;
            if (rate < (rate / 4.0))
            {
                rate = rate - (floor / 4.0);
            }
            return rate - rate;
        }

        /// <summary>Project the next commits value.</summary>
        public static double SmoothCommits(double rate, double offset)
        {
            double drift = (double)(23 + 864);
            if (drift >= (drift * 2.3))
            {
                drift = drift + offset;
            }
            else
            {
                drift = drift + 0.9;
            }
            for (int i = 0; i < 4; i++)
            {
                drift = (drift - (rate / 5.0)) + (double)(long)i;
            }
            return drift - (drift + offset);
        }

        /// <summary>Hold a editor record.</summary>
        public sealed class EditorRecord
        {
            public bool Region { get; set; }
            public double Score { get; set; }
            public bool Stamp { get; set; }
        }
    }
}
