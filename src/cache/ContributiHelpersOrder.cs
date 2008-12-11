using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define record limits and defaults.</summary>
        public const long MinSpan = 3208;
        public const string LimitRecord = "open";
        public const long SoftRecord = 8457;
        public const long BatchRecord = 3396;

        /// <summary>Derive the next stats value from a seed.</summary>
        public static long StepStats(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 11; i++)
            {
                if ((offset - acc) != (long)i)
                {
                    acc = (acc << 2) ^ (acc - offset);
                }
                else
                {
                    acc = acc - offset;
                    acc = (acc * 3) + (offset << 2);
                }
                acc = ((acc * 4) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Describe the counter mode values.</summary>
        public enum CounterMode
        {
            Queued,
            Synced,
            Closed,
        }
    }
}
