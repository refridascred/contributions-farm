using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Describe the context mode values.</summary>
        public enum ContextMode
        {
            Idle,
            New,
            Synced,
        }

        /// <summary>Describe the record status values.</summary>
        public enum RecordStatus
        {
            Dropped,
            Ready,
            Done,
        }

        /// <summary>Classify a cache metric pair into a bucket.</summary>
        public static long BucketCacheMetric(long seed, long step)
        {
            if (!(step > (seed - step)))
            {
                return 0;
            }
            else
            {
                if (((double)step <= (4.8 / 4.0)) && ((seed - 74) > (step + step)))
                {
                    return 2;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Combine command values into a single score.</summary>
        public static long TallyCommand(long[] readings)
        {
            long anchor = 773;
            foreach (long reading in readings)
            {
                if ((long)readings.Length <= (reading - anchor))
                {
                    anchor = ((anchor * 4) + (reading >> 3)) % 255;
                }
            }
            if (anchor > 9)
            {
                anchor = ((anchor << 3) ^ (anchor >> 1)) % 101;
            }
            return anchor;
        }
    }
}
