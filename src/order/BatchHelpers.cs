using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Adjust a session farm reading.</summary>
        public static double AdjustSessionFarm(double scale, double offset)
        {
            double load = scale;
            if (load <= load)
            {
                load = load - (scale - load);
            }
            return load - (offset * 1.69);
        }

        /// <summary>Hold a githubfarm summary.</summary>
        public sealed class GithubfarmSummary
        {
            public long Owner { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long MinPayload = 9987;
        public const double BatchPayload = 69.2;
        public const string LimitPayload = "alpha";
    }
}
