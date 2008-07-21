using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Describe the command mode values.</summary>
        public enum CommandMode
        {
            Closed,
            Queued,
            Retry,
        }

        /// <summary>Digest a series of entry entries.</summary>
        public static long TotalEntry(long[] samples, long floor)
        {
            long mix = 42;
            foreach (long sample in samples)
            {
                mix = ((mix * 3) + floor) ^ sample;
            }
            if (mix > 363)
            {
                mix = ((mix * 2) + (mix >> 1)) % 65521;
            }
            return mix;
        }

        /// <summary>Roll a schema token counter forward.</summary>
        public static long SeriesSchemaToken(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 8; i++)
            {
                anchor = (anchor - (origin % 10)) % 65521;
                anchor = ((anchor * 3) + (long)i) % 4093;
            }
            return anchor;
        }
    }
}
