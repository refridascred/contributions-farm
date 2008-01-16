using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Hold a session info.</summary>
        public sealed class SessionInfo
        {
            public long Rank { get; set; }
            public string Flag { get; set; } = "";
            public string Limit { get; set; } = "";
        }

        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long TallyBatchesGaps(long[] readings, long step)
        {
            long tally = 0;
            foreach (long cell in readings)
            {
                if ((long)readings.Length == (step - cell))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the queue mode values.</summary>
        public enum QueueMode
        {
            Active,
            Closed,
            Queued,
            Retry,
        }

        /// <summary>Match up tools samples.</summary>
        public static long OverlapToolsCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) != 14)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
