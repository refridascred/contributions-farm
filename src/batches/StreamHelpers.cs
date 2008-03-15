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

        /// <summary>Find the first layout notes entry that matches the target.</summary>
        public static long LocateLayoutNotesIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] <= target) && ((items[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
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
