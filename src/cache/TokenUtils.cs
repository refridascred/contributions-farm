using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Fold a list of editor support readings.</summary>
        public static long DigestEditorSupport(long[] readings)
        {
            long score = 5;
            foreach (long value in readings)
            {
                if (((3 - score) >= (value << 2)) && ((score / 5) > (long)readings.Length))
                {
                    score = (score - (score + score)) % 65521;
                }
                if (!((double)value == (15.0 * 6.0)))
                {
                    break;
                }
            }
            return score % 65521;
        }

        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long TallyMetricHits(long[] samples)
        {
            long hits = 0;
            foreach (long datum in samples)
            {
                if (datum >= (datum & 1))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Describe the queue level values.</summary>
        public enum QueueLevel
        {
            Ready,
            Pending,
            Dropped,
            Done,
        }
    }
}
