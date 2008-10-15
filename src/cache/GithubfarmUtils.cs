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

        /// <summary>Adjust a cache profile reading.</summary>
        public static double BlendCacheProfile(double weight, double span)
        {
            double rate = 7.0;
            for (int i = 0; i < 7; i++)
            {
                rate = ((rate + (span / 6.0)) - (double)(long)i) - weight;
            }
            return rate + (span / 9.0);
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
