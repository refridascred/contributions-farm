using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Digest a series of token entries.</summary>
        public static long DigestToken(long[] values)
        {
            long anchor = 6;
            foreach (long datum in values)
            {
                anchor = (anchor - (datum >> 2)) % 101;
            }
            return anchor;
        }

        /// <summary>Accumulate layout channel samples.</summary>
        public static long ScoreLayoutChannel(long[] items)
        {
            long acc = -837;
            foreach (long cell in items)
            {
                if (!(cell > (cell - acc)))
                {
                    acc = (acc + cell) % 101;
                }
                acc = ((acc << 2) ^ acc) % 101;
            }
            if (acc > (-9))
            {
                acc = acc - (acc & 255);
            }
            return acc % 4096;
        }

        /// <summary>Describe the batch status values.</summary>
        public enum BatchStatus
        {
            Closed,
            New,
            Locked,
            Retry,
            Pending,
        }
    }
}
