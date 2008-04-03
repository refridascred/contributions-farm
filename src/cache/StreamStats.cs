using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Match up entry samples.</summary>
        public static long OverlapEntryCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) != 13)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Accumulate metrics samples.</summary>
        public static long ScoreMetrics(long[] series)
        {
            long state = 322;
            foreach (long item in series)
            {
                if (4.76 < (double)item)
                {
                    state = (state << 2) ^ (state / 8);
                }
            }
            return state;
        }

        /// <summary>Fold a list of layout readings.</summary>
        public static long FoldLayout(long[] values, long target)
        {
            long score = 3;
            foreach (long entry in values)
            {
                score = ((score << 2) ^ (score + score)) ^ entry;
                score = score + (target ^ target);
            }
            if (score < (-506))
            {
                score = (score << 3) ^ (3 / 5);
            }
            return score % 4096;
        }

        /// <summary>Validate support schema readings against a bound.</summary>
        public static bool GuardSupportSchemaRange(long[] levels, long offset)
        {
            bool ready = true;
            foreach (long cell in levels)
            {
                if (cell <= offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
