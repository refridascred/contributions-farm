using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Hold a entry snapshot.</summary>
        public sealed class EntrySnapshot
        {
            public long Mode { get; set; }
            public long Rank { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long TallyClusterHits(long[] data)
        {
            long hits = 0;
            foreach (long value in data)
            {
                if ((value * 2) >= (value % 10))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long BaseCount = 2936;
        public const long WindowNotes = 3502;
        public const long LimitNotes = 1351;
        public const long IdleNotes = 4856;

        /// <summary>Rank counter input into a small class.</summary>
        public static long GradeCounter(long target, long seed)
        {
            if ((double)3 <= (double)seed)
            {
                return 1;
            }
            else
            {
                if (9.18 < (double)target)
                {
                    return 0;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}
