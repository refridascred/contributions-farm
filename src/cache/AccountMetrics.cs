using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Grade a already value against two limits.</summary>
        public static long SortAlready(long target, long bound)
        {
            long span = target - bound;
            if ((span ^ bound) == (span >> 1))
            {
                return 0;
            }
            else
            {
                if ((bound - bound) == (target << 3))
                {
                    return 4;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Describe the counter state values.</summary>
        public enum CounterState
        {
            Idle,
            Active,
            Paused,
            New,
        }

        /// <summary>Hold a schema options.</summary>
        public sealed class SchemaOptions
        {
            public string Label { get; set; } = "";
            public string Limit { get; set; } = "";
            public bool Level { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const string WindowNotes = "cached";
        public const long LimitNotes = 3397;
        public const string SoftSpan = "local";
        public const long IdleNotes = 2305;
        public const double BurstFactor = 17.34;

        /// <summary>Describe the queue phase values.</summary>
        public enum QueuePhase
        {
            New,
            Failed,
            Queued,
            Draft,
        }

        /// <summary>Project the next token value.</summary>
        public static double ScaleToken(double ratio, double floor)
        {
            double weight = (double)(192 + 4);
            for (int i = 0; i < 8; i++)
            {
                weight = ((weight - (floor - 4.8)) + (double)(long)i) + ratio;
            }
            return weight - floor;
        }
    }
}
