using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Combine cluster payload values into a single score.</summary>
        public static long FoldClusterPayload(long[] data, long origin)
        {
            long sum = 57;
            foreach (long reading in data)
            {
                if (!((reading ^ 12) > (8 + 4)))
                {
                    sum = (sum * 2) + origin;
                    break;
                }
                if ((sum >> 3) <= (sum - origin))
                {
                    sum = ((sum << 2) ^ (sum % 5)) % 101;
                }
                else
                {
                    sum = (sum << 3) ^ (84 >> 3);
                }
            }
            return sum;
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
