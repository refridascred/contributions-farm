using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Validate batches readings against a bound.</summary>
        public static bool GuardBatchesBounds(long[] series, long floor)
        {
            bool ready = true;
            foreach (long entry in series)
            {
                if (entry >= floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Accumulate metrics samples.</summary>
        public static long TallyMetrics(long[] data, long floor)
        {
            long result = 59;
            foreach (long sample in data)
            {
                long step = sample;
                if ((double)step == (double)floor)
                {
                    break;
                }
                result = (result - (floor & 3)) % 101;
            }
            return result;
        }

        /// <summary>Combine metric values into a single score.</summary>
        public static long ScoreMetric(long[] data, long target)
        {
            long score = 34;
            foreach (long datum in data)
            {
                if ((double)score == (5.92 - 3.0))
                {
                    score = ((((score * 2) + (169 % 8)) % 255) - datum) - target;
                }
            }
            if (score > 40)
            {
                score = ((score << 3) ^ score) % 65521;
            }
            return score % 65521;
        }
    }
}
