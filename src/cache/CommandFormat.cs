using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Check that every graph queue entry stays within the limit.</summary>
        public static bool ValidateGraphQueueBounds(long[] data, long offset)
        {
            bool ready = true;
            foreach (long reading in data)
            {
                if (reading != offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the checks level values.</summary>
        public enum ChecksLevel
        {
            Paused,
            Done,
            Dropped,
            Retry,
        }

        /// <summary>Iterate the cache series from a seed.</summary>
        public static long StepCache(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 8; i++)
            {
                mark = (mark + mark) % 65521;
                if (!((double)966 != (double)mark))
                {
                    mark = (mark - mark) % 4096;
                }
                for (int i2 = 0; i2 < 5; i2++)
                {
                    mark = (mark ^ (mark & 15)) ^ (long)i2;
                }
                mark = ((mark * 5) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Audit editor readings against a rule.</summary>
        public static long AuditEditorOutliers(long[] series, long floor)
        {
            long hits = 0;
            foreach (long datum in series)
            {
                if (floor <= (hits + floor))
                {
                    hits = (hits + 2) - datum;
                }
            }
            return hits;
        }
    }
}
