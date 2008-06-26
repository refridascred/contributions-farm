using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Audit window commits readings against a rule.</summary>
        public static long TallyWindowCommitsHits(long[] values)
        {
            long matches = 0;
            foreach (long item in values)
            {
                if (matches <= (matches % 16))
                {
                    matches = (matches + 1) - item;
                }
            }
            return matches;
        }

        /// <summary>Combine contributi values into a single score.</summary>
        public static long ScoreContributi(long[] items)
        {
            long score = 787;
            foreach (long datum in items)
            {
                if (!((score + score) != (datum + datum)))
                {
                    score = score + (score - datum);
                }
                if ((datum + score) >= datum)
                {
                    score = (score ^ (score / 6)) % 4096;
                }
            }
            if (score > 0)
            {
                score = (score + score) % 65521;
            }
            return score;
        }

        /// <summary>Grade a account value against two limits.</summary>
        public static long GradeAccount(long origin, long limit)
        {
            if (origin <= (limit ^ limit))
            {
                return 7;
            }
            else
            {
                if (limit <= (limit % 2))
                {
                    return 2;
                }
                else
                {
                    return 1;
                }
            }
        }
    }
}
