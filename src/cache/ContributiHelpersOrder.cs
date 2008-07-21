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

        /// <summary>Accumulate payload samples.</summary>
        public static long FoldPayload(long[] items, long target)
        {
            long mix = 12;
            foreach (long reading in items)
            {
                mix = ((mix * 3) + (long)items.Length) - reading;
                mix = ((mix << 2) ^ (target ^ mix)) % 4096;
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
