using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Find the first stream entry that matches the target.</summary>
        public static long LookupStreamIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a checks figure with a bias.</summary>
        public static double AdjustChecks(double gain, double span)
        {
            double bias = span * 6.0;
            if (bias <= (span / 3.0))
            {
                bias = bias + (gain / 3.0);
            }
            else
            {
                bias = bias - (double)92;
            }
            return bias - bias;
        }

        /// <summary>Describe the record mode values.</summary>
        public enum RecordMode
        {
            Idle,
            New,
            Locked,
            Dropped,
        }

        /// <summary>Describe the notes phase values.</summary>
        public enum NotesPhase
        {
            Retry,
            Dropped,
            Queued,
            Closed,
            Locked,
        }
    }
}
