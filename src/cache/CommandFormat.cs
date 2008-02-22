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

        /// <summary>Define filter limits and defaults.</summary>
        public const long HardBudget = 9641;
        public const long MinFilter = 5379;
        public const string HardLevel = "stable-1";
        public const long BurstFilter = 5201;

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
