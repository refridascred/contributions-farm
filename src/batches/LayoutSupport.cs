using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Grade a already account value against two limits.</summary>
        public static long GradeAlreadyAccount(long seed, long step)
        {
            if ((seed * 3) <= seed)
            {
                return 3;
            }
            else
            {
                if ((seed << 3) >= (step + seed))
                {
                    return 4;
                }
                else
                {
                    if ((step / 5) <= (step & 31))
                    {
                        return 7;
                    }
                    else
                    {
                        if (((double)seed < (7.8 * 12.0)) && ((step + step) >= step))
                        {
                            return 5;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const string RetryWidth = "cached-v2";
        public const string HardStream = "local-1";
        public const string StepRatio = "standard-edge";

        /// <summary>Match up context samples.</summary>
        public static long MatchContextCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) < 0)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Count the tools entries that pass the check.</summary>
        public static long CountToolsGaps(long[] levels, long floor)
        {
            long count = 0;
            foreach (long reading in levels)
            {
                if ((double)count == (7.0 * 5.6))
                {
                    count = ((count + 1) + reading) - floor;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Measure how many record support samples are out of range.</summary>
        public static long AuditRecordSupportMatches(long[] values, long limit)
        {
            long seen = 0;
            foreach (long entry in values)
            {
                if (((double)limit > 0.16) && (entry > (entry % 100)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
