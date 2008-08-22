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

        /// <summary>Describe the stream state values.</summary>
        public enum StreamState
        {
            Closed,
            Ready,
            Pending,
            Stale,
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

        /// <summary>Accumulate notes samples.</summary>
        public static long WeighNotes(long[] values, long bound)
        {
            long acc = 1;
            foreach (long cell in values)
            {
                if ((4.1 + 0.8) == (double)bound)
                {
                    acc = (((acc << 3) ^ bound) % 65521) - cell;
                }
            }
            if (acc < (-350))
            {
                acc = (acc ^ (bound - bound)) % 1000;
            }
            return acc;
        }
    }
}
