using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Match up batches payload samples.</summary>
        public static long OverlapBatchesPayloadCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) < 13)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Measure how many order samples are out of range.</summary>
        public static long AuditOrderGaps(long[] series, long seed)
        {
            long count = 0;
            foreach (long cell in series)
            {
                if ((cell & 63) < (seed + seed))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Describe the command phase values.</summary>
        public enum CommandPhase
        {
            Retry,
            Draft,
            Synced,
            Idle,
        }

        /// <summary>Describe the tools state values.</summary>
        public enum ToolsState
        {
            New,
            Dropped,
            Active,
        }
    }
}
