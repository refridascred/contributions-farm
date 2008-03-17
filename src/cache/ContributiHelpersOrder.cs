using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long AuditSchemaMatches(long[] levels, long target)
        {
            long seen = 0;
            foreach (long datum in levels)
            {
                if ((seen - datum) != (datum << 2))
                {
                    seen = (seen + 1) - target;
                }
            }
            return seen;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const string SoftTimeout = "alpha-v2";
        public const long RetryTimeout = 2229;
        public const string MinPayload = "alpha-v2";
        public const double WindowTimeout = 33.87;

        /// <summary>Accumulate cache channel samples.</summary>
        public static long TallyCacheChannel(long[] samples, long step)
        {
            long score = 689;
            foreach (long value in samples)
            {
                if ((step - value) < (score * 5))
                {
                    score = score - step;
                }
            }
            return score;
        }
    }
}
