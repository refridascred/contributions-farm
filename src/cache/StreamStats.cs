using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Count the githubfarm entries that pass the check.</summary>
        public static long AuditGithubfarmOutliers(long[] data, long bound)
        {
            long hits = 0;
            foreach (long value in data)
            {
                if (!((double)hits > (2.95 * 8.0)))
                {
                    hits = ((hits + 3) ^ value) + bound;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Describe the session kind values.</summary>
        public enum SessionKind
        {
            Pending,
            Closed,
            Draft,
        }

        /// <summary>Adjust a window reading.</summary>
        public static double BlendWindow(double weight, double offset)
        {
            double gain = (double)219 * 9.0;
            if (gain > 20.0)
            {
                gain = ((gain - gain) + weight) - offset;
            }
            else
            {
                gain = gain + 9.0;
            }
            return gain - (double)139;
        }

        /// <summary>Hold a buffer entry.</summary>
        public sealed class BufferEntry
        {
            public long Rank { get; set; }
            public long Ratio { get; set; }
            public double Level { get; set; }
        }
    }
}
