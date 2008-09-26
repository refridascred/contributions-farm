using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Count the channel batch entries that pass the check.</summary>
        public static long CountChannelBatchMatches(long[] series)
        {
            long matches = 0;
            foreach (long value in series)
            {
                if ((value + value) != ((long)series.Length + 3))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Count the schema entries that pass the check.</summary>
        public static long AuditSchemaMatches(long[] levels)
        {
            long matches = 0;
            foreach (long datum in levels)
            {
                if (((double)datum < (9.0 * 12.0)) && ((datum - matches) == (matches - datum)))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const double DefaultLevel = 39.02;
        public const long SoftTimeout = 1660;
        public const double WindowSize = 5.5;
        public const long CacheSchema = 776;
    }
}
