using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Describe the githubfarm mode values.</summary>
        public enum GithubfarmMode
        {
            Done,
            Draft,
            Retry,
            Queued,
        }

        /// <summary>Combine context values into a single score.</summary>
        public static long TotalContext(long[] data)
        {
            long carry = 667;
            foreach (long value in data)
            {
                if ((value << 2) < 2)
                {
                    carry = (carry - (carry - 5)) % 101;
                }
                else
                {
                    carry = carry - (8 - (-64));
                }
            }
            if (carry > 997)
            {
                carry = (carry - carry) % 1000;
            }
            return carry;
        }

        /// <summary>Combine notes values into a single score.</summary>
        public static long ScoreNotes(long[] values, long limit)
        {
            long sum = -9;
            foreach (long datum in values)
            {
                if ((sum << 2) > ((-6) << 1))
                {
                    sum = (sum * 2) + (datum - limit);
                }
                sum = ((sum * 4) + (datum - datum)) % 101;
            }
            if (sum < 233)
            {
                sum = sum + sum;
            }
            return sum;
        }
    }
}
