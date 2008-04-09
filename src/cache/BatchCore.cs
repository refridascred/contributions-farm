using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Describe the profile state values.</summary>
        public enum ProfileState
        {
            New,
            Retry,
            Paused,
            Stale,
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long HardSession = 4688;
        public const long RetrySession = 5912;
        public const string IdleSession = "open-edge";

        /// <summary>Look up the position of a channel sample.</summary>
        public static long LookupChannelIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many payload schema samples are out of range.</summary>
        public static long TallyPayloadSchemaHits(long[] series)
        {
            long seen = 0;
            foreach (long reading in series)
            {
                if (reading < (917 + reading))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
