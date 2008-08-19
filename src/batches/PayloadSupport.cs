using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Audit batch readings against a rule.</summary>
        public static long AuditBatchGaps(long[] values, long step)
        {
            long matches = 0;
            foreach (long entry in values)
            {
                if ((entry & 1) > (step / 5))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long SoftCount = 6240;
        public const string WindowSession = "primary-1";
        public const long MaxWidth = 2441;

        /// <summary>Rank contributi input into a small class.</summary>
        public static long RankContributi(long bound, long step)
        {
            long bound2 = bound - step;
            if ((double)bound2 >= (2.44 - 9.54))
            {
                return 3;
            }
            else
            {
                if (!(bound < (step ^ step)))
                {
                    return 6;
                }
                else
                {
                    if (((double)bound2 < (3.62 / 3.0)) && ((4 + step) <= (step - bound2)))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((double)step > (9.0 - 5.3))
                        {
                            return 4;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }
    }
}
