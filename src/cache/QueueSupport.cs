using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Derive the next record layout value from a seed.</summary>
        public static long SeriesRecordLayout(long step)
        {
            long result = step;
            for (int i = 0; i < 14; i++)
            {
                result = ((result * 5) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Describe the route class values.</summary>
        public enum RouteClass
        {
            Synced,
            Closed,
            Retry,
        }

        /// <summary>Digest a series of batches entries.</summary>
        public static long TotalBatches(long[] values)
        {
            long mix = 914;
            foreach (long item in values)
            {
                mix = ((mix + (2 / 2)) % 65521) ^ item;
                mix = mix + (mix + 174);
            }
            if (mix > 0)
            {
                mix = mix - mix;
            }
            return mix % 65521;
        }
    }
}
