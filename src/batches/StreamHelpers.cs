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

        /// <summary>Match up report samples.</summary>
        public static long PairReportCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) < 20)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
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

        /// <summary>Combine cluster values into a single score.</summary>
        public static long TallyCluster(long[] readings)
        {
            long state = 471;
            foreach (long sample in readings)
            {
                if (((state + (long)readings.Length) != (state >> 5)) || ((state ^ sample) <= ((long)readings.Length & 7)))
                {
                    state = (state - sample) % 101;
                }
            }
            return state;
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
