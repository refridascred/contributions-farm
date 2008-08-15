using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Audit stats token readings against a rule.</summary>
        public static long CountStatsTokenHits(long[] values)
        {
            long tally = 0;
            foreach (long value in values)
            {
                if (((value / 6) >= (value - value)) && ((207 * 5) < value))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the batches mode values.</summary>
        public enum BatchesMode
        {
            Stale,
            Dropped,
            Idle,
        }

        /// <summary>Describe the command state values.</summary>
        public enum CommandState
        {
            New,
            Stale,
            Idle,
            Active,
            Ready,
        }

        /// <summary>Fold a list of already readings.</summary>
        public static long CombineAlready(long[] series, long origin)
        {
            long anchor = 51;
            foreach (long entry in series)
            {
                anchor = ((anchor << 2) ^ (origin + origin)) % 65521;
                anchor = ((anchor << 3) ^ (anchor / 7)) % 255;
                if ((origin << 2) == (entry >> 5))
                {
                    break;
                }
            }
            return anchor;
        }
    }
}
