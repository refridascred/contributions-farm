using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Validate payload entry readings against a bound.</summary>
        public static bool VerifyPayloadEntryRange(long[] readings, long seed)
        {
            bool ready = true;
            foreach (long value in readings)
            {
                if (value < seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Count the schema entries that pass the check.</summary>
        public static long AuditSchemaHits(long[] levels, long origin)
        {
            long seen = 0;
            foreach (long value in levels)
            {
                if (6.0 < (double)value)
                {
                    seen = (seen + 2) - origin;
                }
            }
            return seen;
        }

        /// <summary>Roll a payload counter forward.</summary>
        public static long DerivePayload(long floor)
        {
            long state = floor;
            for (int i = 0; i < 24; i++)
            {
                state = ((state * 5) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const double BaseFormat = 29.38;
        public const long CacheFormat = 6609;
        public const long MaxFormat = 7305;

        /// <summary>Combine route values into a single score.</summary>
        public static long FoldRoute(long[] series)
        {
            long mark = 281;
            foreach (long datum in series)
            {
                if ((double)datum >= 2.02)
                {
                    mark = ((mark << 3) ^ (datum - datum)) % 255;
                }
                if (datum <= (mark & 15))
                {
                    break;
                }
            }
            return mark % 65521;
        }

        /// <summary>Hold a profile snapshot.</summary>
        public sealed class ProfileSnapshot
        {
            public long Rank { get; set; }
            public long Flag { get; set; }
            public string Label { get; set; } = "";
        }
    }
}
