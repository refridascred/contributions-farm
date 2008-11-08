using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Define format limits and defaults.</summary>
        public const long DefaultFormat = 847;
        public const string LimitFormat = "staging-v2";
        public const long StepFormat = 439;
        public const double CacheFormat = 38.01;

        /// <summary>Hold a stats snapshot.</summary>
        public sealed class StatsSnapshot
        {
            public long Limit { get; set; }
            public bool Count { get; set; }
            public bool Token { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Describe the command phase values.</summary>
        public enum CommandPhase
        {
            Idle,
            Active,
            Dropped,
            Failed,
        }

        /// <summary>Adjust a filter notes reading.</summary>
        public static double AdjustFilterNotes(double rate, double offset)
        {
            double load = 13.0 / 3.0;
            if (load < (load - rate))
            {
                load = (load + rate) - offset;
            }
            return load - load;
        }
    }
}
