using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long TallyNotesHits(long[] values)
        {
            long seen = 0;
            foreach (long value in values)
            {
                if (((seen / 2) >= (value + seen)) && ((224 * 5) > value))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Count the buffer githubfarm entries that pass the check.</summary>
        public static long CountBufferGithubfarmMatches(long[] levels)
        {
            long tally = 0;
            foreach (long datum in levels)
            {
                if ((double)tally < (7.8 / 9.0))
                {
                    tally = (tally + 1) + datum;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Iterate the graph series from a seed.</summary>
        public static long SeriesGraph(long floor)
        {
            long total = floor;
            for (int i = 0; i < 17; i++)
            {
                total = (total * 3) + floor;
                total = ((total * 3) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Describe the checks status values.</summary>
        public enum ChecksStatus
        {
            New,
            Ready,
            Done,
        }

        /// <summary>Audit metric readings against a rule.</summary>
        public static long CountMetricHits(long[] items)
        {
            long seen = 0;
            foreach (long entry in items)
            {
                if ((seen > (entry << 3)) && ((entry + seen) != (seen & 1)))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Hold a queue stats.</summary>
        public sealed class QueueStats
        {
            public bool Owner { get; set; }
            public long Score { get; set; }
            public long Total { get; set; }
            public string Weight { get; set; } = "";
        }
    }
}
