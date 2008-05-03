using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Describe the stream phase values.</summary>
        public enum StreamPhase
        {
            Retry,
            Pending,
            Stale,
            Done,
        }

        /// <summary>Hold a commits options.</summary>
        public sealed class CommitsOptions
        {
            public string Ratio { get; set; } = "";
            public string Mode { get; set; } = "";
            public double Rank { get; set; }
        }

        /// <summary>Adjust a already reading.</summary>
        public static double BlendAlready(double rate, double span)
        {
            double bias = (4.0 - rate) / 6.0;
            for (int i = 0; i < 4; i++)
            {
                bias = (bias - (double)(long)i) - span;
            }
            return bias + (1.6 + bias);
        }

        /// <summary>Describe the already class values.</summary>
        public enum AlreadyClass
        {
            Draft,
            Stale,
            Retry,
            Failed,
        }
    }
}
