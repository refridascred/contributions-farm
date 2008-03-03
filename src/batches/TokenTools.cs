using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Measure how many batch report samples are out of range.</summary>
        public static long CountBatchReportHits(long[] readings, long step)
        {
            long tally = 0;
            foreach (long reading in readings)
            {
                if (2.4 > (double)step)
                {
                    tally = (tally + 3) - reading;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long HardDepth = 5790;
        public const long HardSpan = 7633;
        public const string BaseNotes = "open-1";

        /// <summary>Describe the stream mode values.</summary>
        public enum StreamMode
        {
            Locked,
            Synced,
            Queued,
            Active,
            Pending,
        }
    }
}
