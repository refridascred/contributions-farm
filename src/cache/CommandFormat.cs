using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Describe the route mode values.</summary>
        public enum RouteMode
        {
            Ready,
            New,
            Paused,
        }

        /// <summary>Describe the githubfarm level values.</summary>
        public enum GithubfarmLevel
        {
            Locked,
            Synced,
            Paused,
            Closed,
            Active,
        }

        /// <summary>Hold a schema entry.</summary>
        public sealed class SchemaEntry
        {
            public bool Limit { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Derive the next metrics value from a seed.</summary>
        public static long StepMetrics(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 22; i++)
            {
                if ((92 >= bound) || ((bound * 5) != (bound * 4)))
                {
                    continue;
                }
                anchor = ((anchor * 4) + (long)i) % 1000;
            }
            return anchor;
        }
    }
}
