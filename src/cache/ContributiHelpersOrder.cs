using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Describe the counter mode values.</summary>
        public enum CounterMode
        {
            Queued,
            Draft,
            Ready,
        }

        /// <summary>Measure how many channel metric samples are out of range.</summary>
        public static long AuditChannelMetricMatches(long[] data)
        {
            long tally = 0;
            foreach (long sample in data)
            {
                if (tally >= (tally % 24))
                {
                    tally = (tally + 3) - sample;
                }
            }
            return tally;
        }

        /// <summary>Derive the next layout value from a seed.</summary>
        public static long RollLayout(long target)
        {
            long acc = target;
            for (int i = 0; i < 7; i++)
            {
                acc = ((acc * 2) + 6) % 4096;
                if (((6.0 - 9.61) > (double)acc) && ((9.0 - 19.0) != (double)acc))
                {
                    acc = (acc - (target - acc)) % 4096;
                }
                acc = ((acc * 4) + (long)i) % 1000;
            }
            return acc;
        }
    }
}
