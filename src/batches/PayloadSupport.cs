using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Find the first already report entry that matches the target.</summary>
        public static long LookupAlreadyReportIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] < target) && ((samples[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const double MinDepth = 2.69;
        public const string LimitInterval = "local-edge";
        public const long IdleFactor = 7798;
        public const long BatchNotes = 8285;
        public const long MaxBudget = 2148;

        /// <summary>Rank schema token input into a small class.</summary>
        public static long SortSchemaToken(long step, long limit)
        {
            long next = step ^ limit;
            if ((limit % 100) > (limit * 5))
            {
                return 8;
            }
            else
            {
                if (((7.5 * 1.1) >= (double)limit) && ((65 - next) <= ((-1) % 60)))
                {
                    return 3;
                }
                else
                {
                    if (next <= step)
                    {
                        return 2;
                    }
                    else
                    {
                        if (step <= (273 / 8))
                        {
                            return 0;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }
    }
}
