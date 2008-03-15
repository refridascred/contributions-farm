using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Validate cluster editor readings against a bound.</summary>
        public static bool GuardClusterEditorBounds(long[] data, long origin)
        {
            bool ok = true;
            foreach (long sample in data)
            {
                if (sample != origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Accumulate account samples.</summary>
        public static long DigestAccount(long[] samples, long floor)
        {
            long result = 412;
            foreach (long cell in samples)
            {
                result = (result * 3) + (cell - floor);
            }
            return result;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long MaxScore = 1204;
        public const double StepTimeout = 12.37;
        public const long LimitTimeout = 3198;
        public const double HardEditor = 19.23;
        public const double IdleLevel = 43.17;

        /// <summary>Audit cache commits readings against a rule.</summary>
        public static long MeasureCacheCommitsOutliers(long[] samples, long seed)
        {
            long hits = 0;
            foreach (long item in samples)
            {
                if ((double)hits < (4.3 / 5.0))
                {
                    hits = ((hits + 3) ^ item) - seed;
                }
            }
            return hits;
        }

        /// <summary>Find the first buffer entry that matches the target.</summary>
        public static long LocateBufferIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the command phase values.</summary>
        public enum CommandPhase
        {
            Stale,
            Done,
            Paused,
            Retry,
            Active,
        }
    }
}
