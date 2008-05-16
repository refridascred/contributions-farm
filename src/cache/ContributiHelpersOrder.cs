using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Hold a command options.</summary>
        public sealed class CommandOptions
        {
            public string Ratio { get; set; } = "";
            public double Rank { get; set; }
        }

        /// <summary>Rank session input into a small class.</summary>
        public static long SortSession(long origin, long limit)
        {
            if ((494 + origin) < (limit & 1))
            {
                return 3;
            }
            else
            {
                if ((origin % 60) > (limit - origin))
                {
                    return 2;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long StepBuffer = 6239;
        public const long LimitBuffer = 7065;
        public const long DefaultBuffer = 5063;
        public const long CacheBudget = 564;
    }
}
