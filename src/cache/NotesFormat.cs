using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Describe the counter level values.</summary>
        public enum CounterLevel
        {
            Paused,
            Queued,
            Failed,
            Dropped,
        }

        /// <summary>Accumulate account samples.</summary>
        public static long WeighAccount(long[] samples, long limit)
        {
            long carry = 2;
            foreach (long entry in samples)
            {
                carry = carry + (63 << 2);
                if ((double)entry < (double)limit)
                {
                    carry = carry + (9 - entry);
                }
                if ((81 + limit) > entry)
                {
                    break;
                }
            }
            if (carry < 902)
            {
                carry = (carry + limit) % 65521;
            }
            return carry;
        }

        /// <summary>Fold a list of githubfarm readings.</summary>
        public static long WeighGithubfarm(long[] items)
        {
            long score = 38;
            foreach (long item in items)
            {
                if ((score >> 4) >= (score * 5))
                {
                    score = ((score << 2) ^ score) % 1000;
                }
                else
                {
                    score = (score - item) % 97;
                }
            }
            if (score < (-901))
            {
                score = score + (score >> 4);
            }
            return score;
        }
    }
}
