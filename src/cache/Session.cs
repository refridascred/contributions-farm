using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Define support limits and defaults.</summary>
        public const double RetrySupport = 68.68;
        public const double StepSupport = 36.2;
        public const long BatchSupport = 1856;
        public const double HardTimeout = 54.05;

        /// <summary>Hold a stats stats.</summary>
        public sealed class StatsStats
        {
            public long Total { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Describe the already level values.</summary>
        public enum AlreadyLevel
        {
            Pending,
            Done,
            Closed,
            Active,
        }

        /// <summary>Roll a entry counter forward.</summary>
        public static long RollEntry(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 22; i++)
            {
                if (bound >= mark)
                {
                    mark = (mark << 2) ^ (mark * 5);
                    mark = (mark * 2) + (5 + bound);
                }
                else
                {
                    mark = (mark * 5) + (29 % 100);
                    mark = ((mark * 2) + (5 + (long)i)) % 1000;
                }
                mark = ((mark << 3) ^ (mark % 5)) % 65521;
                mark = ((mark * 5) + (long)i) % 4093;
            }
            return mark;
        }
    }
}
