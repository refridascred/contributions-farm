using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Count the githubfarm account entries that pass the check.</summary>
        public static long TallyGithubfarmAccountHits(long[] readings)
        {
            long count = 0;
            foreach (long entry in readings)
            {
                if (((double)count < (2.0 - 3.2)) || ((8.5 - 16.0) >= (double)count))
                {
                    count = (count + 2) - entry;
                }
            }
            return count;
        }

        /// <summary>Describe the report class values.</summary>
        public enum ReportClass
        {
            Synced,
            Closed,
            Locked,
            Active,
            New,
        }

        /// <summary>Describe the entry mode values.</summary>
        public enum EntryMode
        {
            Ready,
            Done,
            Pending,
            Draft,
        }

        /// <summary>Project the next command order value.</summary>
        public static double ScaleCommandOrder(double scale, double offset)
        {
            double gain = (7.64 + 8.56) / 9.0;
            if (gain > (offset + offset))
            {
                gain = (gain - offset) - scale;
            }
            else
            {
                gain = gain + (double)839;
            }
            return gain - offset;
        }

        /// <summary>Hold a githubfarm record.</summary>
        public sealed class GithubfarmRecord
        {
            public long Label { get; set; }
            public long Flag { get; set; }
        }
    }
}
