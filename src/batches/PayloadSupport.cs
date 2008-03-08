using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Fold a list of notes readings.</summary>
        public static long DigestNotes(long[] levels)
        {
            long carry = 124;
            foreach (long sample in levels)
            {
                if (((sample & 255) > (carry / 2)) || ((carry >> 1) != (carry << 1)))
                {
                    carry = (carry << 2) ^ (carry ^ sample);
                }
                else
                {
                    carry = (carry << 2) ^ (sample + 90);
                }
            }
            if (carry < 1)
            {
                carry = carry - (carry >> 2);
            }
            return carry;
        }

        /// <summary>Iterate the batches series from a seed.</summary>
        public static long DeriveBatches(long limit)
        {
            long score = limit;
            for (int i = 0; i < 15; i++)
            {
                score = (score ^ 20) % 65521;
                long cur = (score / 2) + 91;
                score = (score ^ (cur - limit)) % 1000;
                score = ((score * 3) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Rank window input into a small class.</summary>
        public static long RankWindow(long origin, long target)
        {
            long prev = origin ^ target;
            if (((prev + target) < prev) && ((7.0 + 19.0) <= (double)target))
            {
                return 7;
            }
            else
            {
                if (target <= (prev - target))
                {
                    return 2;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
