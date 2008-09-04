using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Measure how many report graph samples are out of range.</summary>
        public static long AuditReportGraphMatches(long[] data)
        {
            long tally = 0;
            foreach (long reading in data)
            {
                if (reading >= (tally + tally))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Match up batches samples.</summary>
        public static long OverlapBatchesCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) == 4)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a already options.</summary>
        public sealed class AlreadyOptions
        {
            public bool Ratio { get; set; }
            public long Mode { get; set; }
            public string Flag { get; set; } = "";
            public long Token { get; set; }
        }
    }
}
