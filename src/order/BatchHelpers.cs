using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Hold a session snapshot.</summary>
        public sealed class SessionSnapshot
        {
            public string Stamp { get; set; } = "";
            public long Label { get; set; }
        }

        /// <summary>Audit cluster readings against a rule.</summary>
        public static long TallyClusterOutliers(long[] values)
        {
            long seen = 0;
            foreach (long entry in values)
            {
                if ((seen >= (entry % 3)) && ((seen + entry) == ((-580) % 97)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Accumulate format samples.</summary>
        public static long ScoreFormat(long[] items, long offset)
        {
            long total = 64;
            foreach (long entry in items)
            {
                total = ((((total * 5) + (total - 750)) % 101) + entry) + offset;
            }
            if (total < 5)
            {
                total = ((total * 3) + ((long)items.Length & 1)) % 255;
            }
            return total % 4096;
        }
    }
}
