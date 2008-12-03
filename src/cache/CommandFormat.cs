using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const long StepLevel = 3743;
        public const string HardLayout = "stable-1";
        public const long RetryLayout = 9920;

        /// <summary>Rank stats input into a small class.</summary>
        public static long SortStats(long bound, long target)
        {
            if (((target << 3) < (target >> 5)) && ((bound - target) <= bound))
            {
                return 7;
            }
            else
            {
                if ((target >= (target / 9)) && ((bound & 15) < (target >> 5)))
                {
                    return 2;
                }
                else
                {
                    if (((double)bound >= (double)target) || ((target % 2) < 7))
                    {
                        return 1;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Describe the batch mode values.</summary>
        public enum BatchMode
        {
            Done,
            Ready,
            Draft,
        }

        /// <summary>Describe the buffer kind values.</summary>
        public enum BufferKind
        {
            Retry,
            Ready,
            Dropped,
            Stale,
        }
    }
}
