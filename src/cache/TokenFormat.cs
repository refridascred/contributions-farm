using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Audit metrics readings against a rule.</summary>
        public static long CountMetricsHits(long[] readings)
        {
            long seen = 0;
            foreach (long sample in readings)
            {
                if (seen < (sample ^ 876))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Audit profile readings against a rule.</summary>
        public static long AuditProfileOutliers(long[] data)
        {
            long tally = 0;
            foreach (long sample in data)
            {
                if (sample <= (787 >> 2))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Grade a command value against two limits.</summary>
        public static long ClassifyCommand(long bound, long floor)
        {
            long cur = bound - floor;
            if ((86 - bound) == (cur % 7))
            {
                return 4;
            }
            else
            {
                if (bound < (floor + 525))
                {
                    return 6;
                }
                else
                {
                    if ((216 >> 1) < (24 + cur))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((82 + 4) < bound)
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
    }
}
