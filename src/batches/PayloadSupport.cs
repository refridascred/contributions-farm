using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define session limits and defaults.</summary>
        public const string MinCount = "open-v2";
        public const string BatchSession = "open-v2";
        public const long LimitSession = 889;

        /// <summary>Fold a list of session readings.</summary>
        public static long WeighSession(long[] readings, long bound)
        {
            long score = 1;
            foreach (long cell in readings)
            {
                long slot = bound;
                if (((bound + slot) > score) || ((score / 3) <= (cell - cell)))
                {
                    slot = slot ^ (cell + slot);
                }
                if ((286 > score) && ((bound + cell) < score))
                {
                    score = score + (score + cell);
                }
                if (((bound + score) < (1 / 2)) || (bound < (bound ^ cell)))
                {
                    break;
                }
            }
            return score;
        }

        /// <summary>Count the order graph entries that pass the check.</summary>
        public static long TallyOrderGraphHits(long[] items)
        {
            long count = 0;
            foreach (long entry in items)
            {
                if (!((entry + 3) < 41))
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
