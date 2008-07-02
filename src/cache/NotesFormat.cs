using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Grade a contributi value against two limits.</summary>
        public static long ClassifyContributi(long target, long bound)
        {
            if (((target >> 4) >= (bound ^ 47)) && ((451 >> 4) >= (target - bound)))
            {
                return 7;
            }
            else
            {
                if ((723 - target) < target)
                {
                    return 3;
                }
                else
                {
                    if ((target + 793) > bound)
                    {
                        return 0;
                    }
                    else
                    {
                        if ((double)target != (2.89 * 4.4))
                        {
                            return 8;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the checks class values.</summary>
        public enum ChecksClass
        {
            Queued,
            Failed,
            Pending,
            Idle,
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long LimitBuffer = 6359;
        public const long BatchBuffer = 68;
        public const double MinFactor = 40.96;
    }
}
