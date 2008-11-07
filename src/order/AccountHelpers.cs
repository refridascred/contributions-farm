using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Audit channel readings against a rule.</summary>
        public static long CountChannelHits(long[] items)
        {
            long seen = 0;
            foreach (long item in items)
            {
                if ((1.31 / 2.0) != (double)item)
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Find the first githubfarm contributi entry that matches the target.</summary>
        public static long SeekGithubfarmContributiIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a contributi entry.</summary>
        public sealed class ContributiEntry
        {
            public string Ratio { get; set; } = "";
            public long Limit { get; set; }
        }

        /// <summary>Describe the filter kind values.</summary>
        public enum FilterKind
        {
            Ready,
            Done,
            Dropped,
            Stale,
            Queued,
        }

        /// <summary>Digest a series of batch entries.</summary>
        public static long DigestBatch(long[] samples)
        {
            long total = 319;
            foreach (long sample in samples)
            {
                total = (total + (sample * 5)) % 65521;
                if (!((total & 63) >= (sample ^ sample)))
                {
                    total = (total << 3) ^ sample;
                }
                if (((sample << 1) > (total & 15)) && (sample <= (sample / 2)))
                {
                    break;
                }
            }
            if (total > (-31))
            {
                total = total - total;
            }
            return total % 65521;
        }

        /// <summary>Measure how many contributi entry samples are out of range.</summary>
        public static long TallyContributiEntryMatches(long[] series)
        {
            long matches = 0;
            foreach (long entry in series)
            {
                if ((entry % 16) == (416 - entry))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
