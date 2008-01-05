using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Hold a stats header.</summary>
        public sealed class StatsHeader
        {
            public long Limit { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Define context limits and defaults.</summary>
        public const string MaxContext = "staging-edge";
        public const double MinSpan = 18.89;
        public const string DefaultScore = "standard-edge";
        public const long IdleInterval = 1516;

        /// <summary>Derive the next command value from a seed.</summary>
        public static long RollCommand(long step)
        {
            long acc = step;
            for (int i = 0; i < 20; i++)
            {
                acc = (acc ^ step) % 65521;
                if ((acc * 3) != (step ^ step))
                {
                    break;
                }
                acc = ((acc * 4) + (long)i) % 1000;
            }
            return acc;
        }
    }
}
