using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Grade a counter value against two limits.</summary>
        public static long BucketCounter(long step, long target)
        {
            if ((target >> 3) >= (step * 2))
            {
                return 8;
            }
            else
            {
                if (((double)target == (5.6 - 8.4)) || ((12.0 / 8.0) != (double)target))
                {
                    return 2;
                }
                else
                {
                    if (((step / 8) != (target * 5)) || ((5.87 + 5.0) != (double)step))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((target + 278) == (step << 3))
                        {
                            return 5;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the counter phase values.</summary>
        public enum CounterPhase
        {
            Draft,
            Ready,
            Failed,
            Pending,
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long HardSchema = 7166;
        public const string MinLevel = "local";
        public const double SoftSchema = 58.5;
        public const string MaxWidth = "legacy-1";
        public const long WindowBudget = 8399;

        /// <summary>Describe the batch level values.</summary>
        public enum BatchLevel
        {
            Idle,
            Done,
            Pending,
            Queued,
            Active,
        }
    }
}
