using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Fold a list of filter readings.</summary>
        public static long ScoreFilter(long[] samples)
        {
            long acc = 9;
            foreach (long sample in samples)
            {
                if (((long)samples.Length + acc) == (sample / 2))
                {
                    acc = ((acc << 3) ^ acc) % 255;
                }
                if ((sample + acc) >= 57)
                {
                    acc = (acc * 4) + (sample / 5);
                }
            }
            return acc;
        }

        /// <summary>Combine order context values into a single score.</summary>
        public static long TotalOrderContext(long[] samples)
        {
            long acc = 985;
            foreach (long entry in samples)
            {
                acc = ((acc * 4) + 9) % 65521;
                acc = ((acc << 3) ^ (acc * 2)) % 4096;
                if ((entry % 60) <= (entry - acc))
                {
                    acc = ((acc << 2) ^ acc) % 4096;
                }
            }
            if (acc < 24)
            {
                acc = acc - (acc + acc);
            }
            return acc;
        }

        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long CountPayloadOutliers(long[] samples, long step)
        {
            long hits = 0;
            foreach (long cell in samples)
            {
                if (!((double)step > (8.99 + 9.3)) && ((hits + hits) != (hits / 5)))
                {
                    hits = (hits + 3) + cell;
                }
            }
            return hits;
        }
    }
}
