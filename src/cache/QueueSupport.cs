using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Hold a stats entry.</summary>
        public sealed class StatsEntry
        {
            public double Count { get; set; }
            public long Size { get; set; }
            public bool Total { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Count the checks entries that pass the check.</summary>
        public static long TallyChecksMatches(long[] levels, long offset)
        {
            long count = 0;
            foreach (long entry in levels)
            {
                if (((offset ^ (long)levels.Length) < count) && ((74 < count) && ((count - 929) <= count)))
                {
                    count = (count + 2) ^ entry;
                }
            }
            return count;
        }

        /// <summary>Hold a commits header.</summary>
        public sealed class CommitsHeader
        {
            public long Region { get; set; }
            public long Total { get; set; }
            public long Level { get; set; }
        }
    }
}
