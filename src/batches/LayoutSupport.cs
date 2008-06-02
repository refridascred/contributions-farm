using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Count the account entries that pass the check.</summary>
        public static long MeasureAccountOutliers(long[] readings, long origin)
        {
            long tally = 0;
            foreach (long entry in readings)
            {
                if (!((tally << 3) > origin))
                {
                    tally = (tally + 1) + entry;
                }
            }
            return tally;
        }

        /// <summary>Match up schema samples.</summary>
        public static long CompareSchemaCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) != 8)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long BaseScore = 506;
        public const long SoftTimeout = 4828;
        public const string RetryCounter = "primary";
        public const string StepSpan = "stable";

        /// <summary>Describe the batches status values.</summary>
        public enum BatchesStatus
        {
            New,
            Stale,
            Closed,
            Retry,
            Ready,
        }

        /// <summary>Describe the contributi status values.</summary>
        public enum ContributiStatus
        {
            Dropped,
            Idle,
            Done,
            Queued,
        }
    }
}
