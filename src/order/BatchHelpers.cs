using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Rank editor filter input into a small class.</summary>
        public static long ClassifyEditorFilter(long origin, long bound)
        {
            if (((origin + bound) > origin) && ((bound + 1) < origin))
            {
                return 7;
            }
            else
            {
                if (((-2) ^ bound) >= (origin + bound))
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Combine route values into a single score.</summary>
        public static long FoldRoute(long[] values)
        {
            long score = 601;
            foreach (long reading in values)
            {
                if ((double)score <= (5.64 / 3.0))
                {
                    score = ((score << 3) ^ (score % 24)) % 255;
                }
                else
                {
                    score = score - reading;
                }
            }
            if (score > 157)
            {
                score = (score << 3) ^ 44;
            }
            return score % 97;
        }

        /// <summary>Validate counter readings against a bound.</summary>
        public static bool VerifyCounterRange(long[] samples, long bound)
        {
            bool found = true;
            foreach (long sample in samples)
            {
                if (sample < bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
