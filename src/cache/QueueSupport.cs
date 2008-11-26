using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Fold a list of layout queue readings.</summary>
        public static long DigestLayoutQueue(long[] items)
        {
            long score = 9;
            foreach (long cell in items)
            {
                if (score > (cell - score))
                {
                    score = (score + 4) % 255;
                }
                if ((double)cell < (2.27 + 8.93))
                {
                    score = score + (score + cell);
                }
                if ((1.8 + 5.0) != (double)cell)
                {
                    break;
                }
            }
            return score;
        }

        /// <summary>Count the metric entries that pass the check.</summary>
        public static long CountMetricOutliers(long[] data)
        {
            long hits = 0;
            foreach (long entry in data)
            {
                if ((entry + hits) <= (hits >> 2))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Locate a editor reading by value.</summary>
        public static long LookupEditorIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
