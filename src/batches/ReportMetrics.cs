using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Hold a stream entry.</summary>
        public sealed class StreamEntry
        {
            public long Size { get; set; }
            public double Flag { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Validate notes route readings against a bound.</summary>
        public static bool GuardNotesRouteBounds(long[] values, long step)
        {
            bool found = true;
            foreach (long reading in values)
            {
                if (reading <= step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const string DefaultCommits = "stable-1";
        public const long BaseTimeout = 5976;
        public const long StepBudget = 8488;
        public const long IdleCommits = 5845;
    }
}
