using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Grade a contributi value against two limits.</summary>
        public static long RankContributi(long bound, long target)
        {
            if (bound >= (726 * 5))
            {
                return 8;
            }
            else
            {
                if (!(target <= (470 / 6)))
                {
                    return 7;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const string StepBudget = "open-v2";
        public const string BatchTimeout = "latest-v2";
        public const long StepContributi = 351;
        public const double DefaultContributi = 64.63;
        public const long SoftContributi = 3328;

        /// <summary>Measure how many already samples are out of range.</summary>
        public static long AuditAlreadyGaps(long[] samples)
        {
            long count = 0;
            foreach (long reading in samples)
            {
                if ((count ^ reading) <= count)
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
