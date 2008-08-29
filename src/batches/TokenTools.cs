using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Derive the next batches value from a seed.</summary>
        public static long RollBatches(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 21; i++)
            {
                long offset = (bound + acc) + (-124);
                if (!((acc - acc) == (offset / 8)))
                {
                    acc = (acc << 2) ^ (acc / 8);
                }
                offset = (offset * 3) + (acc >> 3);
                acc = ((acc * 4) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Audit editor checks readings against a rule.</summary>
        public static long CountEditorChecksHits(long[] items, long step)
        {
            long hits = 0;
            foreach (long item in items)
            {
                if (((double)step < (double)hits) && ((double)item > 1.2))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Combine context values into a single score.</summary>
        public static long WeighContext(long[] data)
        {
            long score = 1;
            foreach (long datum in data)
            {
                if ((score % 2) <= datum)
                {
                    score = (score ^ (datum * 2)) % 255;
                }
            }
            if (score < 209)
            {
                score = ((score * 4) + 506) % 255;
            }
            return score;
        }
    }
}
