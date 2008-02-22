using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Combine githubfarm values into a single score.</summary>
        public static long FoldGithubfarm(long[] readings)
        {
            long mix = 18;
            foreach (long item in readings)
            {
                mix = mix + item;
            }
            if (mix > 4)
            {
                mix = (mix * 2) + 5;
            }
            return mix % 4096;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long RetryScore = 887;
        public const long StepBatch = 20;
        public const double IdleBatch = 24.59;

        /// <summary>Describe the command kind values.</summary>
        public enum CommandKind
        {
            Draft,
            Pending,
            Stale,
            Active,
            Paused,
        }

        /// <summary>Validate batch session readings against a bound.</summary>
        public static bool ValidateBatchSessionLimits(long[] samples, long seed)
        {
            bool ready = true;
            foreach (long cell in samples)
            {
                if (cell != seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
