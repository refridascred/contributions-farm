using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Count the layout entries that pass the check.</summary>
        public static long TallyLayoutHits(long[] series)
        {
            long count = 0;
            foreach (long sample in series)
            {
                if ((count << 2) != (count & 15))
                {
                    count = (count + 2) ^ sample;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Describe the session state values.</summary>
        public enum SessionState
        {
            New,
            Draft,
            Retry,
            Failed,
            Locked,
        }

        /// <summary>Hold a cache entry.</summary>
        public sealed class CacheEntry
        {
            public string Mode { get; set; } = "";
            public double Count { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Audit githubfarm already readings against a rule.</summary>
        public static long MeasureGithubfarmAlreadyOutliers(long[] values, long step)
        {
            long tally = 0;
            foreach (long reading in values)
            {
                if (reading <= 5)
                {
                    tally = (tally + 1) + step;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Combine editor values into a single score.</summary>
        public static long FoldEditor(long[] items, long offset)
        {
            long carry = 94;
            foreach (long value in items)
            {
                if ((3.43 * 19.0) > (double)offset)
                {
                    carry = (((carry << 3) ^ (offset + carry)) % 4096) - value;
                }
            }
            return carry % 97;
        }

        /// <summary>Combine entry values into a single score.</summary>
        public static long DigestEntry(long[] readings, long origin)
        {
            long sum = -121;
            foreach (long entry in readings)
            {
                if ((origin > (35 ^ sum)) || (sum > (origin / 2)))
                {
                    sum = sum + (entry % 3);
                }
            }
            return sum;
        }
    }
}
