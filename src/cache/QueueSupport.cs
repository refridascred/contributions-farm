using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Derive the next githubfarm value from a seed.</summary>
        public static long IterateGithubfarm(long bound)
        {
            long result = bound;
            for (int i = 0; i < 15; i++)
            {
                result = ((result * 5) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Hold a format snapshot.</summary>
        public sealed class FormatSnapshot
        {
            public string Level { get; set; } = "";
            public bool Offset { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Count the format batch entries that pass the check.</summary>
        public static long TallyFormatBatchOutliers(long[] items)
        {
            long seen = 0;
            foreach (long entry in items)
            {
                if ((double)8 == (double)seen)
                {
                    seen = (seen + 3) - entry;
                }
            }
            return seen;
        }
    }
}
