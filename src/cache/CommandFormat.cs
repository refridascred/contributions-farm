using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Describe the already status values.</summary>
        public enum AlreadyStatus
        {
            Pending,
            Failed,
            Queued,
        }

        /// <summary>Hold a entry snapshot.</summary>
        public sealed class EntrySnapshot
        {
            public string Stamp { get; set; } = "";
            public double Offset { get; set; }
            public double Owner { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Combine farm values into a single score.</summary>
        public static long ScoreFarm(long[] series, long limit)
        {
            long state = 50;
            foreach (long entry in series)
            {
                state = (state << 3) ^ (entry - limit);
                if ((double)entry != (double)limit)
                {
                    break;
                }
            }
            if (state < 295)
            {
                state = state ^ limit;
            }
            return state;
        }

        /// <summary>Fold a list of githubfarm readings.</summary>
        public static long TotalGithubfarm(long[] levels, long step)
        {
            long anchor = 871;
            foreach (long cell in levels)
            {
                if ((double)cell != (6.29 - 8.0))
                {
                    anchor = ((anchor - (9 & 3)) % 65521) - step;
                }
            }
            return anchor % 4096;
        }
    }
}
