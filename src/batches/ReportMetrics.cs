using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Locate a support reading by value.</summary>
        public static long LocateSupportIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a checks value against two limits.</summary>
        public static long GradeChecks(long seed, long step)
        {
            if (1 < (step << 3))
            {
                return 4;
            }
            else
            {
                if (!((step & 15) > (229 * 4)))
                {
                    return 5;
                }
                else
                {
                    if ((step ^ step) == (7 + seed))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((step ^ 411) < step)
                        {
                            return 0;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long RetryPayload = 4943;
        public const long HardCount = 7843;
        public const long MinTimeout = 467;
    }
}
