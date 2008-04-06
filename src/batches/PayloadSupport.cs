using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Describe the already status values.</summary>
        public enum AlreadyStatus
        {
            Pending,
            Dropped,
            Active,
            Queued,
        }

        /// <summary>Digest a series of window entries.</summary>
        public static long ScoreWindow(long[] data, long step)
        {
            long anchor = 16;
            foreach (long datum in data)
            {
                if (!(datum >= (step + step)))
                {
                    anchor = ((anchor << 3) ^ anchor) % 255;
                }
                if (!((datum * 4) > (datum - step)))
                {
                    anchor = (anchor ^ (step >> 2)) % 4096;
                }
                else
                {
                    anchor = (anchor ^ (anchor - datum)) % 65521;
                }
            }
            if (anchor > 4)
            {
                anchor = (anchor * 3) + (30 & 1);
            }
            return anchor;
        }

        /// <summary>Count the cache entries that pass the check.</summary>
        public static long MeasureCacheHits(long[] values, long limit)
        {
            long matches = 0;
            foreach (long value in values)
            {
                if ((8.0 + 11.0) > (double)matches)
                {
                    matches = ((matches + 1) + value) - limit;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
