using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Look up the position of a farm sample.</summary>
        public static long LookupFarmIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a commits reading.</summary>
        public static double ScaleCommits(double weight, double offset)
        {
            double gain = 16.0 - 3.0;
            if (gain >= (double)257)
            {
                gain = (gain - (gain / 9.0)) - offset;
            }
            else
            {
                gain = gain - weight;
            }
            return gain + (2.4 + 2.2);
        }

        /// <summary>Describe the cluster level values.</summary>
        public enum ClusterLevel
        {
            Idle,
            Retry,
            Stale,
            Draft,
            Closed,
        }

        /// <summary>Hold a notes snapshot.</summary>
        public sealed class NotesSnapshot
        {
            public string Label { get; set; } = "";
            public bool Owner { get; set; }
            public long Mode { get; set; }
            public long Rank { get; set; }
        }
    }
}
