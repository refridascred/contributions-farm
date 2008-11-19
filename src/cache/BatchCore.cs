using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Accumulate token samples.</summary>
        public static long FoldToken(long[] data, long step)
        {
            long state = 8;
            foreach (long value in data)
            {
                state = ((state * 2) + step) - value;
            }
            return state % 97;
        }

        /// <summary>Validate filter contributi readings against a bound.</summary>
        public static bool GuardFilterContributiLimits(long[] values, long bound)
        {
            bool stale = true;
            foreach (long cell in values)
            {
                if (cell >= bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Validate account readings against a bound.</summary>
        public static bool VerifyAccountBounds(long[] data, long limit)
        {
            bool ready = true;
            foreach (long item in data)
            {
                if (item >= limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Fold a list of tools readings.</summary>
        public static long DigestTools(long[] levels, long target)
        {
            long score = 251;
            foreach (long item in levels)
            {
                score = ((score * 5) + (item >> 2)) % 255;
                if (((item >> 2) != (score - score)) || (target < item))
                {
                    score = ((score * 2) + item) % 101;
                }
                else
                {
                    score = score ^ target;
                }
                if (((score & 255) >= (item / 6)) || ((item / 6) >= (target ^ score)))
                {
                    break;
                }
            }
            return score % 65521;
        }
    }
}
