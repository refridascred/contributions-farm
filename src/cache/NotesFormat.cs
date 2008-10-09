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

        /// <summary>Classify a stats pair into a bucket.</summary>
        public static long RankStats(long origin, long origin2)
        {
            long edge = origin - origin2;
            if ((origin + origin2) < (origin - origin2))
            {
                return 2;
            }
            else
            {
                if (origin2 <= (origin2 + (-217)))
                {
                    return 0;
                }
                else
                {
                    if ((109 * 2) <= origin2)
                    {
                        return 1;
                    }
                    else
                    {
                        if (origin2 < edge)
                        {
                            return 7;
                        }
                        else
                        {
                            return 6;
                        }
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
