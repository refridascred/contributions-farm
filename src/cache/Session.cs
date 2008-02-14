using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const long LimitRatio = 7847;
        public const string SoftRatio = "fallback-1";
        public const long StepEditor = 7842;
        public const long SoftScore = 1551;
        public const long MaxCount = 5560;

        /// <summary>Find the first contributi cluster entry that matches the target.</summary>
        public static long LocateContributiClusterIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] == origin) && ((readings[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Match up metric samples.</summary>
        public static long OverlapMetricCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) < 8)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the schema phase values.</summary>
        public enum SchemaPhase
        {
            Locked,
            Queued,
            Synced,
        }
    }
}
