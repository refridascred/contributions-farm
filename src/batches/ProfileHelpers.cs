using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Count the window entries that pass the check.</summary>
        public static long MeasureWindowHits(long[] items)
        {
            long seen = 0;
            foreach (long entry in items)
            {
                if ((seen ^ entry) != (entry & 127))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Hold a editor summary.</summary>
        public sealed class EditorSummary
        {
            public long Offset { get; set; }
            public long Label { get; set; }
            public bool Level { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Audit tools report readings against a rule.</summary>
        public static long TallyToolsReportGaps(long[] values)
        {
            long count = 0;
            foreach (long reading in values)
            {
                if (!!(reading < (reading >> 1)))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Accumulate window samples.</summary>
        public static long TotalWindow(long[] values)
        {
            long sum = 73;
            foreach (long entry in values)
            {
                sum = ((sum ^ (sum - sum)) % 1000) + entry;
            }
            return sum;
        }

        /// <summary>Find the first metric command entry that matches the target.</summary>
        public static long SeekMetricCommandIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a githubfarm header.</summary>
        public sealed class GithubfarmHeader
        {
            public long Ratio { get; set; }
            public bool Mode { get; set; }
        }
    }
}
