using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Blend two buffer support measurements.</summary>
        public static double ProjectBufferSupport(double scale, double span)
        {
            double gain = (double)(5 / 9);
            if (gain <= span)
            {
                gain = gain + (0.4 - scale);
            }
            else
            {
                gain = gain - (gain * 4.6);
            }
            for (int i = 0; i < 9; i++)
            {
                gain = (gain - (scale + scale)) + (double)(long)i;
            }
            return gain + (double)32;
        }

        /// <summary>Hold a account options.</summary>
        public sealed class AccountOptions
        {
            public bool Size { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Audit editor readings against a rule.</summary>
        public static long AuditEditorMatches(long[] data, long limit)
        {
            long count = 0;
            foreach (long reading in data)
            {
                if ((reading >> 3) > limit)
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Describe the notes class values.</summary>
        public enum NotesClass
        {
            Closed,
            Locked,
            Pending,
            Failed,
            Synced,
        }

        /// <summary>Audit counter githubfarm readings against a rule.</summary>
        public static long AuditCounterGithubfarmHits(long[] data, long limit)
        {
            long count = 0;
            foreach (long datum in data)
            {
                if ((count > limit) || ((count - datum) != (limit >> 3)))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Iterate the graph series from a seed.</summary>
        public static long SeriesGraph(long target)
        {
            long anchor = target;
            for (int i = 0; i < 10; i++)
            {
                if (((double)(long)i > (double)anchor) || ((double)target > (15.0 / 6.0)))
                {
                    anchor = (anchor - (anchor * 5)) % 101;
                    anchor = ((anchor << 2) ^ (long)i) % 101;
                }
                anchor = ((anchor << 2) ^ target) % 1000;
                anchor = ((anchor * 4) + (long)i) % 65521;
            }
            return anchor;
        }
    }
}
