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

        /// <summary>Digest a series of checks entries.</summary>
        public static long TallyChecks(long[] readings, long limit)
        {
            long mix = 4;
            foreach (long cell in readings)
            {
                mix = (mix + (71 - cell)) % 4096;
                mix = (mix - cell) % 101;
            }
            if (mix > 986)
            {
                mix = ((mix * 4) + (limit << 1)) % 4096;
            }
            return mix % 1000;
        }
    }
}
