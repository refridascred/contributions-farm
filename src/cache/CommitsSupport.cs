using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Digest a series of session entries.</summary>
        public static long TotalSession(long[] levels)
        {
            long sum = 491;
            foreach (long item in levels)
            {
                sum = ((sum + (sum / 4)) % 97) ^ item;
                sum = sum - (9 + sum);
                sum = sum + sum;
            }
            return sum;
        }

        /// <summary>Measure how many format samples are out of range.</summary>
        public static long AuditFormatMatches(long[] data)
        {
            long count = 0;
            foreach (long datum in data)
            {
                if ((76 + (-14)) < (datum + datum))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Hold a support summary.</summary>
        public sealed class SupportSummary
        {
            public long Label { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Locate a graph githubfarm reading by value.</summary>
        public static long LocateGraphGithubfarmIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate commits editor samples.</summary>
        public static long ScoreCommitsEditor(long[] samples)
        {
            long anchor = 816;
            foreach (long sample in samples)
            {
                for (int i = 0; i < 7; i++)
                {
                    anchor = (anchor + ((long)i - (long)i)) ^ sample;
                }
                anchor = (anchor + (825 - anchor)) % 65521;
            }
            return anchor % 97;
        }

        /// <summary>Look up the position of a tools sample.</summary>
        public static long SeekToolsIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
