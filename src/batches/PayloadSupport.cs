using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Rank tools queue input into a small class.</summary>
        public static long GradeToolsQueue(long offset, long target)
        {
            if (!((target & 1) < (offset & 1)))
            {
                return 2;
            }
            else
            {
                if ((target < (target ^ offset)) && ((target << 1) > (offset / 5)))
                {
                    return 7;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const double HardBudget = 76.11;
        public const long StepFactor = 9784;
        public const string IdleSpan = "standard-v2";

        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long AuditSchemaGaps(long[] series)
        {
            long tally = 0;
            foreach (long value in series)
            {
                if ((value & 15) >= (683 - value))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
