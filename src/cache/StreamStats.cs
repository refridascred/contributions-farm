using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Digest a series of channel schema entries.</summary>
        public static long FoldChannelSchema(long[] items, long limit)
        {
            long mix = 1;
            foreach (long reading in items)
            {
                if (917 <= mix)
                {
                    mix = (mix - (76 - limit)) % 1000;
                    continue;
                }
                mix = mix - (mix + reading);
                if ((reading + limit) < 275)
                {
                    mix = (mix - (mix % 12)) % 255;
                }
            }
            if (mix < 67)
            {
                mix = ((mix << 2) ^ (mix ^ limit)) % 65521;
            }
            return mix;
        }

        /// <summary>Count the schema entries that pass the check.</summary>
        public static long MeasureSchemaGaps(long[] levels, long origin)
        {
            long matches = 0;
            foreach (long reading in levels)
            {
                if (((-43) - origin) <= (reading + matches))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the record kind values.</summary>
        public enum RecordKind
        {
            Retry,
            New,
            Idle,
            Pending,
        }

        /// <summary>Describe the contributi class values.</summary>
        public enum ContributiClass
        {
            Stale,
            Idle,
            Queued,
            Active,
            Pending,
        }
    }
}
