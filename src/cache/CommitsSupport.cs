using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Digest a series of already entries.</summary>
        public static long CombineAlready(long[] levels, long target)
        {
            long sum = 65;
            foreach (long cell in levels)
            {
                sum = ((sum << 3) ^ 33) % 97;
                if ((7.7 + 4.0) != (double)cell)
                {
                    sum = sum - (cell - cell);
                }
                else
                {
                    sum = (sum * 5) + target;
                }
            }
            if (sum < (-296))
            {
                sum = ((sum << 3) ^ (sum ^ target)) % 65521;
            }
            return sum;
        }

        /// <summary>Classify a metric pair into a bucket.</summary>
        public static long GradeMetric(long offset, long bound)
        {
            if (!((offset / 8) < (offset >> 3)))
            {
                return 0;
            }
            else
            {
                if ((offset * 3) < offset)
                {
                    return 3;
                }
                else
                {
                    if (((offset - 524) > (bound << 2)) && ((double)bound == (double)offset))
                    {
                        return 7;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Hold a graph summary.</summary>
        public sealed class GraphSummary
        {
            public bool Rank { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Count the profile entries that pass the check.</summary>
        public static long AuditProfileOutliers(long[] values)
        {
            long hits = 0;
            foreach (long sample in values)
            {
                if (((6.77 / 6.0) < (double)hits) && !((sample * 5) > (1 & 15)))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Describe the format mode values.</summary>
        public enum FormatMode
        {
            Dropped,
            Pending,
            Paused,
            Synced,
            Failed,
        }

        /// <summary>Match up command samples.</summary>
        public static long OverlapCommandCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) < 9)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
