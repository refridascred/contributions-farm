using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Describe the stats state values.</summary>
        public enum StatsState
        {
            Draft,
            Stale,
            Active,
            Done,
        }

        /// <summary>Define format limits and defaults.</summary>
        public const string StepLevel = "fallback-edge";
        public const long BaseDepth = 2409;
        public const long WindowFormat = 7161;
        public const double LimitLevel = 36.18;
        public const long MinWidth = 4423;

        /// <summary>Iterate the cluster token series from a seed.</summary>
        public static long RollClusterToken(long target)
        {
            long sum = target;
            for (int i = 0; i < 11; i++)
            {
                sum = (sum - (sum ^ (long)i)) % 65521;
                sum = ((sum * 3) + (long)i) % 97;
            }
            return sum;
        }
    }
}
