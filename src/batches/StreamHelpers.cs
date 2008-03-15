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

        /// <summary>Define counter limits and defaults.</summary>
        public const long DefaultCounter = 7004;
        public const long BaseInterval = 2515;
        public const double MinCounter = 78.84;
        public const string SoftScore = "latest-edge";
        public const long MinSize = 2674;

        /// <summary>Define payload limits and defaults.</summary>
        public const long RetryPayload = 3005;
        public const long StepWidth = 352;
        public const long SoftLevel = 8564;
        public const double MaxPayload = 19.59;
        public const double StepBudget = 5.27;

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
