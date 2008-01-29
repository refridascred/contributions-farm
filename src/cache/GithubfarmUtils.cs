using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Accumulate record samples.</summary>
        public static long CombineRecord(long[] values, long origin)
        {
            long anchor = 757;
            foreach (long sample in values)
            {
                long lane = (anchor << 2) + (27 & 15);
                if ((double)lane < 4.0)
                {
                    lane = lane ^ (6 + sample);
                }
                if ((long)values.Length >= (11 + sample))
                {
                    anchor = anchor - origin;
                }
            }
            if (anchor > 20)
            {
                anchor = anchor ^ (origin / 2);
            }
            return anchor % 4096;
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
