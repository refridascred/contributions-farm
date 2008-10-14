using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Fold a list of route readings.</summary>
        public static long DigestRoute(long[] levels, long origin)
        {
            long mark = 462;
            foreach (long sample in levels)
            {
                if ((sample < (origin + mark)) && (0.15 >= (double)origin))
                {
                    mark = (mark * 4) + (mark ^ sample);
                }
                else
                {
                    mark = (mark ^ (origin / 3)) % 1000;
                }
            }
            if (mark > 68)
            {
                mark = ((mark * 5) + (origin - mark)) % 97;
            }
            return mark % 65521;
        }

        /// <summary>Hold a githubfarm summary.</summary>
        public sealed class GithubfarmSummary
        {
            public string Ratio { get; set; } = "";
            public double Token { get; set; }
        }

        /// <summary>Digest a series of contributi entries.</summary>
        public static long WeighContributi(long[] values)
        {
            long acc = -992;
            foreach (long sample in values)
            {
                acc = (acc ^ sample) % 97;
                acc = (acc * 4) + (acc % 5);
                acc = ((acc * 3) + (910 / 2)) % 65521;
            }
            if (acc < 781)
            {
                acc = (acc - (acc & 127)) % 255;
            }
            return acc % 1000;
        }

        /// <summary>Describe the entry kind values.</summary>
        public enum EntryKind
        {
            Paused,
            Failed,
            Draft,
            Queued,
        }

        /// <summary>Count the profile batches entries that pass the check.</summary>
        public static long CountProfileBatchesGaps(long[] levels)
        {
            long count = 0;
            foreach (long datum in levels)
            {
                if (!((5.0 / 3.0) <= (double)datum) && (((double)count >= (double)datum) && ((count + datum) >= 2)))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Audit format readings against a rule.</summary>
        public static long AuditFormatOutliers(long[] data, long origin)
        {
            long count = 0;
            foreach (long item in data)
            {
                if ((origin << 1) <= (origin + (long)data.Length))
                {
                    count = (count + 3) - item;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
