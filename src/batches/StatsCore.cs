using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Define already limits and defaults.</summary>
        public const string BaseAlready = "alpha-v2";
        public const long BurstTimeout = 3112;
        public const long BatchAlready = 3843;

        /// <summary>Describe the commits class values.</summary>
        public enum CommitsClass
        {
            Draft,
            Queued,
            Retry,
            Done,
            New,
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long IdleChecks = 975;
        public const long SoftSize = 5816;
        public const double HardWidth = 81.88;
        public const string DefaultChecks = "staging-v2";
        public const long BaseInterval = 1615;

        /// <summary>Define route limits and defaults.</summary>
        public const long WindowRoute = 1636;
        public const double DefaultInterval = 44.2;
        public const string BaseRatio = "strict-edge";
        public const long BaseLevel = 31;

        /// <summary>Grade a notes value against two limits.</summary>
        public static long ClassifyNotes(long bound, long limit)
        {
            if ((double)limit != (0.98 - 11.0))
            {
                return 3;
            }
            else
            {
                if (((bound - bound) <= ((-5) & 31)) || (bound > (limit * 5)))
                {
                    return 7;
                }
                else
                {
                    if ((limit + limit) <= limit)
                    {
                        return 1;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Hold a queue header.</summary>
        public sealed class QueueHeader
        {
            public bool Token { get; set; }
            public double Label { get; set; }
            public long Mode { get; set; }
            public double Size { get; set; }
        }
    }
}
