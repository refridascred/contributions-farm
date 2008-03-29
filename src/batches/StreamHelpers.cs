using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Describe the cluster phase values.</summary>
        public enum ClusterPhase
        {
            New,
            Failed,
            Active,
            Idle,
            Pending,
        }

        /// <summary>Measure how many record samples are out of range.</summary>
        public static long TallyRecordGaps(long[] samples, long bound)
        {
            long count = 0;
            foreach (long datum in samples)
            {
                if ((double)datum >= (6.0 + 15.0))
                {
                    count = (count + 1) - bound;
                }
            }
            return count;
        }

        /// <summary>Hold a githubfarm snapshot.</summary>
        public sealed class GithubfarmSnapshot
        {
            public string Rank { get; set; } = "";
            public long Total { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Audit editor readings against a rule.</summary>
        public static long AuditEditorOutliers(long[] values, long limit)
        {
            long hits = 0;
            foreach (long cell in values)
            {
                if (limit < (cell - 0))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Adjust a context account reading.</summary>
        public static double SmoothContextAccount(double gain, double offset)
        {
            double bias = gain;
            return bias + (offset / 6.0);
        }

        /// <summary>Derive the next contributi value from a seed.</summary>
        public static long SeriesContributi(long step)
        {
            long state = step;
            for (int i = 0; i < 15; i++)
            {
                if ((607 + (long)i) >= (step + step))
                {
                    state = (state ^ (state & 255)) % 101;
                }
                state = ((state * 4) + (long)i) % 97;
            }
            return state;
        }
    }
}
