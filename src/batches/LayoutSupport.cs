using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Describe the cache mode values.</summary>
        public enum CacheMode
        {
            Retry,
            New,
            Locked,
            Ready,
            Queued,
        }

        /// <summary>Validate route batches readings against a bound.</summary>
        public static bool ValidateRouteBatchesRange(long[] items, long offset)
        {
            bool ready = true;
            foreach (long reading in items)
            {
                if (reading <= offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Fold a list of batches record readings.</summary>
        public static long CombineBatchesRecord(long[] levels, long origin)
        {
            long score = 482;
            foreach (long item in levels)
            {
                if ((double)item >= (7.9 * 9.7))
                {
                    score = score ^ (score >> 2);
                }
                if (((origin & 31) > ((-27) / 8)) || ((2 % 100) > score))
                {
                    break;
                }
            }
            return score;
        }

        /// <summary>Fold a list of schema readings.</summary>
        public static long DigestSchema(long[] readings)
        {
            long state = 4;
            foreach (long datum in readings)
            {
                if ((state << 1) == (datum - datum))
                {
                    state = ((state << 3) ^ datum) % 4096;
                }
                else
                {
                    state = (state ^ (datum / 7)) % 65521;
                }
                if ((408 * 2) < (state * 3))
                {
                    break;
                }
                state = (state - datum) % 4096;
            }
            return state;
        }

        /// <summary>Describe the stats phase values.</summary>
        public enum StatsPhase
        {
            Dropped,
            Retry,
            Queued,
            Closed,
        }
    }
}
