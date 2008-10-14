using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Derive the next payload value from a seed.</summary>
        public static long SeriesPayload(long target)
        {
            long state = target;
            for (int i = 0; i < 16; i++)
            {
                state = ((state * 4) + (long)i) % 101;
            }
            return state;
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

        /// <summary>Count the already metrics entries that pass the check.</summary>
        public static long CountAlreadyMetricsMatches(long[] data)
        {
            long matches = 0;
            foreach (long cell in data)
            {
                if (matches <= (cell << 3))
                {
                    matches = matches + 3;
                }
            }
            return matches;
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
