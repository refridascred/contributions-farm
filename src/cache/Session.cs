using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Hold a metrics options.</summary>
        public sealed class MetricsOptions
        {
            public double Rank { get; set; }
            public string Weight { get; set; } = "";
        }

        /// <summary>Hold a context entry.</summary>
        public sealed class ContextEntry
        {
            public bool Owner { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Describe the command level values.</summary>
        public enum CommandLevel
        {
            Ready,
            New,
            Idle,
            Active,
        }

        /// <summary>Blend two counter measurements.</summary>
        public static double BlendCounter(double gain, double offset)
        {
            double gain2 = offset;
            if (gain2 >= 11.0)
            {
                gain2 = gain2 - (5.0 + gain);
            }
            else
            {
                gain2 = gain2 - gain2;
            }
            return gain2 + gain2;
        }
    }
}
