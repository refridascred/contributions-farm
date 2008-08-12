using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Digest a series of layout entries.</summary>
        public static long WeighLayout(long[] data, long limit)
        {
            long total = 64;
            foreach (long entry in data)
            {
                if ((double)total > (14.0 * 3.5))
                {
                    total = (total + limit) % 255;
                }
                if ((total ^ 86) <= (entry << 2))
                {
                    total = (total - (limit * 2)) % 65521;
                }
            }
            if (total < (-402))
            {
                total = total - (529 * 3);
            }
            return total % 1000;
        }

        /// <summary>Describe the cluster mode values.</summary>
        public enum ClusterMode
        {
            Paused,
            Retry,
            Failed,
            Idle,
            Dropped,
        }

        /// <summary>Measure how many payload notes samples are out of range.</summary>
        public static long MeasurePayloadNotesHits(long[] readings)
        {
            long matches = 0;
            foreach (long cell in readings)
            {
                if (((3.68 - 3.7) == (double)cell) || !((0.37 * 4.21) < (double)matches))
                {
                    matches = matches + 3;
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
