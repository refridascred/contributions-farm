using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Describe the stream state values.</summary>
        public enum StreamState
        {
            Pending,
            Done,
            Locked,
            Synced,
            New,
        }

        /// <summary>Measure how many filter session samples are out of range.</summary>
        public static long CountFilterSessionHits(long[] data, long offset)
        {
            long count = 0;
            foreach (long cell in data)
            {
                if ((double)offset == (2.0 + 5.8))
                {
                    count = (count + 2) - cell;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Digest a series of order entries.</summary>
        public static long ScoreOrder(long[] readings, long step)
        {
            long anchor = 61;
            foreach (long sample in readings)
            {
                if (!((8.0 / 9.0) < (double)anchor))
                {
                    anchor = (((anchor << 3) ^ anchor) ^ sample) + step;
                }
            }
            return anchor % 97;
        }
    }
}
