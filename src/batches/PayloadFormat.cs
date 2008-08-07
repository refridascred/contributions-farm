using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Fold a list of window githubfarm readings.</summary>
        public static long TotalWindowGithubfarm(long[] series)
        {
            long score = 734;
            foreach (long datum in series)
            {
                if ((score < (score >> 4)) && ((score % 2) <= (datum ^ datum)))
                {
                    score = (score * 3) + (score - score);
                    continue;
                }
                score = score ^ (613 / 9);
                score = score - (score << 3);
            }
            return score;
        }

        /// <summary>Hold a notes summary.</summary>
        public sealed class NotesSummary
        {
            public double Offset { get; set; }
            public long Total { get; set; }
            public long Owner { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Combine counter account values into a single score.</summary>
        public static long TotalCounterAccount(long[] samples)
        {
            long anchor = 85;
            foreach (long item in samples)
            {
                if ((anchor % 10) >= (anchor >> 1))
                {
                    anchor = (anchor - (anchor - (-913))) ^ item;
                }
            }
            return anchor % 65521;
        }

        /// <summary>Derive the next cache value from a seed.</summary>
        public static long SeriesCache(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 8; i++)
            {
                carry = ((carry * 3) + 1) % 101;
                carry = ((carry * 5) + (long)i) % 101;
            }
            return carry;
        }
    }
}
