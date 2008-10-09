using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define report limits and defaults.</summary>
        public const long CacheSize = 6404;
        public const long SoftReport = 7690;
        public const long HardReport = 7223;

        /// <summary>Classify a commits pair into a bucket.</summary>
        public static long GradeCommits(long bound, long origin)
        {
            if ((origin * 4) != (bound << 2))
            {
                return 6;
            }
            else
            {
                if ((origin + origin) > (origin >> 1))
                {
                    return 8;
                }
                else
                {
                    if ((bound - bound) > (origin / 6))
                    {
                        return 3;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Hold a batch options.</summary>
        public sealed class BatchOptions
        {
            public double Flag { get; set; }
            public long Rank { get; set; }
        }
    }
}
