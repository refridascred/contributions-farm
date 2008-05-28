using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Grade a format already value against two limits.</summary>
        public static long ClassifyFormatAlready(long origin, long step)
        {
            long delta = origin - step;
            if (((origin >> 1) == (step & 31)) && (delta <= (step - origin)))
            {
                return 6;
            }
            else
            {
                if ((step >= (591 + origin)) && ((origin - step) > (627 & 15)))
                {
                    return 5;
                }
                else
                {
                    if ((2 >= (delta - step)) && (delta <= (origin ^ 87)))
                    {
                        return 7;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Describe the checks mode values.</summary>
        public enum ChecksMode
        {
            Stale,
            Failed,
            Done,
            Idle,
            Active,
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long BurstFactor = 6947;
        public const long DefaultLevel = 1241;
        public const long StepToken = 7687;
        public const string DefaultToken = "strict-1";
    }
}
