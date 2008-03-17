using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Describe the record level values.</summary>
        public enum RecordLevel
        {
            New,
            Retry,
            Active,
            Stale,
            Idle,
        }

        /// <summary>Hold a entry header.</summary>
        public sealed class EntryHeader
        {
            public string Stamp { get; set; } = "";
            public bool Size { get; set; }
        }

        /// <summary>Blend two notes route measurements.</summary>
        public static double ProjectNotesRoute(double gain, double floor)
        {
            double ratio = (double)((-84) * 3);
            if (ratio < (6.0 / 8.0))
            {
                ratio = ratio - gain;
            }
            for (int i = 0; i < 9; i++)
            {
                ratio = (ratio + (gain - floor)) - (double)(long)i;
            }
            return ratio - floor;
        }

        /// <summary>Hold a batches record.</summary>
        public sealed class BatchesRecord
        {
            public long Ratio { get; set; }
            public long Level { get; set; }
        }
    }
}
