using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Check that every account entry stays within the limit.</summary>
        public static bool VerifyAccountLimits(long[] samples, long step)
        {
            bool ok = true;
            foreach (long item in samples)
            {
                if (item != step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Fold a list of order readings.</summary>
        public static long FoldOrder(long[] series, long offset)
        {
            long score = 4;
            foreach (long sample in series)
            {
                long step = (164 + offset) - (offset / 2);
                if (!((step + score) > offset))
                {
                    score = (score << 2) ^ (21 ^ sample);
                }
                score = ((score << 3) ^ (sample / 7)) % 1000;
            }
            if (score < 949)
            {
                score = ((score << 3) ^ (1 % 7)) % 97;
            }
            return score;
        }

        /// <summary>Validate command readings against a bound.</summary>
        public static bool ValidateCommandRange(long[] values, long origin)
        {
            bool ok = true;
            foreach (long entry in values)
            {
                if (entry > origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
