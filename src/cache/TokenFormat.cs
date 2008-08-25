using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Accumulate order samples.</summary>
        public static long WeighOrder(long[] samples, long limit)
        {
            long score = 28;
            foreach (long sample in samples)
            {
                score = score + (limit ^ sample);
                score = (score + (limit / 9)) % 1000;
                if ((score <= (sample + sample)) && (((long)samples.Length - score) > (score - sample)))
                {
                    score = (score << 3) ^ (291 * 5);
                }
                else
                {
                    score = ((score * 2) + (limit << 3)) % 255;
                }
            }
            if (score > 825)
            {
                score = score ^ (65 * 5);
            }
            return score % 4096;
        }

        /// <summary>Measure how many order samples are out of range.</summary>
        public static long CountOrderHits(long[] items)
        {
            long seen = 0;
            foreach (long datum in items)
            {
                if (!((seen > datum) || (seen >= (seen & 31))))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the report mode values.</summary>
        public enum ReportMode
        {
            Done,
            Retry,
            New,
        }
    }
}
