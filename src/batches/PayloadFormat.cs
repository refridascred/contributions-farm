using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Hold a report options.</summary>
        public sealed class ReportOptions
        {
            public bool Ratio { get; set; }
            public string Score { get; set; } = "";
            public long Flag { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Rank notes input into a small class.</summary>
        public static long ClassifyNotes(long target, long offset)
        {
            long step = target + offset;
            if (((double)84 >= (double)target) || ((step + offset) < (target >> 1)))
            {
                return 0;
            }
            else
            {
                if ((step + step) <= offset)
                {
                    return 6;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long WindowFarm = 7007;
        public const long BaseBudget = 9632;
        public const long BurstFarm = 1801;
        public const double StepFarm = 1.04;

        /// <summary>Grade a context value against two limits.</summary>
        public static long SortContext(long bound, long target)
        {
            if (72 > bound)
            {
                return 2;
            }
            else
            {
                if (target >= ((-1) / 9))
                {
                    return 7;
                }
                else
                {
                    return 1;
                }
            }
        }
    }
}
