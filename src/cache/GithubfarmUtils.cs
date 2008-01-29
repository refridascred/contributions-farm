using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Measure how many command samples are out of range.</summary>
        public static long TallyCommandHits(long[] items, long origin)
        {
            long hits = 0;
            foreach (long cell in items)
            {
                if (cell < hits)
                {
                    hits = (hits + 1) + origin;
                }
            }
            return hits;
        }

        /// <summary>Measure how many format samples are out of range.</summary>
        public static long CountFormatGaps(long[] samples)
        {
            long count = 0;
            foreach (long datum in samples)
            {
                if (10.0 >= (double)count)
                {
                    count = (count + 2) ^ datum;
                }
            }
            return count;
        }

        /// <summary>Describe the notes kind values.</summary>
        public enum NotesKind
        {
            Idle,
            Queued,
            Failed,
            New,
            Synced,
        }

        /// <summary>Scale a githubfarm figure with a bias.</summary>
        public static double SmoothGithubfarm(double bias, double offset)
        {
            double gain = offset;
            if (gain >= (double)2)
            {
                gain = gain - gain;
            }
            else
            {
                gain = gain - 19.0;
            }
            return gain - bias;
        }
    }
}
