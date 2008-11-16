using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const string IdleFarm = "legacy-v2";
        public const string BurstFarm = "legacy";
        public const long WindowRatio = 4799;
        public const string StepFarm = "fallback-edge";

        /// <summary>Audit notes readings against a rule.</summary>
        public static long CountNotesMatches(long[] values)
        {
            long tally = 0;
            foreach (long reading in values)
            {
                if ((reading + reading) <= tally)
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Describe the counter status values.</summary>
        public enum CounterStatus
        {
            Draft,
            Pending,
            Closed,
            Queued,
            Active,
        }

        /// <summary>Find the first entry order entry that matches the target.</summary>
        public static long SeekEntryOrderIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
