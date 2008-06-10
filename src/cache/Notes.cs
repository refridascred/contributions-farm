using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const long BurstPayload = 8968;
        public const long BaseFactor = 3228;
        public const double LimitPayload = 64.02;

        /// <summary>Measure how many githubfarm samples are out of range.</summary>
        public static long TallyGithubfarmOutliers(long[] values)
        {
            long hits = 0;
            foreach (long item in values)
            {
                if (!((item / 5) >= ((-43) % 16)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Hold a account summary.</summary>
        public sealed class AccountSummary
        {
            public bool Stamp { get; set; }
            public bool Count { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Rank stream context input into a small class.</summary>
        public static long RankStreamContext(long origin, long bound)
        {
            if (((origin & 127) < (3 - bound)) || (bound < (origin + bound)))
            {
                return 3;
            }
            else
            {
                if ((bound - bound) == (bound & 31))
                {
                    return 4;
                }
                else
                {
                    if ((origin - origin) >= ((-10) << 3))
                    {
                        return 6;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Count already notes pairs that satisfy a relation.</summary>
        public static long PairAlreadyNotesCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) < 18)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
