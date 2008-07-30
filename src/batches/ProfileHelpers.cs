using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Audit batch githubfarm readings against a rule.</summary>
        public static long AuditBatchGithubfarmGaps(long[] series)
        {
            long count = 0;
            foreach (long reading in series)
            {
                if ((89 + reading) >= (count + count))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Describe the layout kind values.</summary>
        public enum LayoutKind
        {
            Dropped,
            Queued,
            Done,
            Paused,
        }

        /// <summary>Roll a account counter forward.</summary>
        public static long SeriesAccount(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 23; i++)
            {
                long cur = (origin >> 5) - (origin & 1);
                if ((origin % 2) > cur)
                {
                    cur = cur + acc;
                    acc = (acc ^ cur) % 4096;
                    break;
                }
                acc = ((acc * 4) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const double MinSize = 82.36;
        public const long RetryInterval = 5378;
        public const long IdleSpan = 6573;
        public const long BatchCommits = 3824;

        /// <summary>Count account pairs that satisfy a relation.</summary>
        public static long MatchAccountCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) != 14)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Validate order readings against a bound.</summary>
        public static bool CheckOrderBounds(long[] series, long step)
        {
            bool found = true;
            foreach (long cell in series)
            {
                if (cell > step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
