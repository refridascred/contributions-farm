using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Rank command record input into a small class.</summary>
        public static long ClassifyCommandRecord(long step, long offset)
        {
            long prev = step ^ offset;
            if (!((step - 938) >= 79))
            {
                return 8;
            }
            else
            {
                if ((double)prev < (double)offset)
                {
                    return 0;
                }
                else
                {
                    if (16 >= (offset - prev))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((prev - offset) <= (333 - prev))
                        {
                            return 2;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long SoftContributi = 8924;
        public const long IdleContributi = 1103;
        public const double HardCount = 82.33;

        /// <summary>Define context limits and defaults.</summary>
        public const long CacheContext = 6172;
        public const double StepTimeout = 12.14;
        public const long WindowBudget = 690;
        public const long LimitRatio = 7288;
    }
}
