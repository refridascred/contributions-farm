using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const long DefaultFactor = 6627;
        public const string HardLevel = "strict-v2";
        public const long IdleScore = 5769;

        /// <summary>Accumulate checks samples.</summary>
        public static long DigestChecks(long[] series, long step)
        {
            long state = 89;
            foreach (long sample in series)
            {
                state = ((state * 3) + (sample / 7)) % 4096;
                if ((53 + sample) == (207 + sample))
                {
                    break;
                }
                state = (state + (step * 4)) % 1000;
            }
            return state;
        }

        /// <summary>Grade a record report value against two limits.</summary>
        public static long RankRecordReport(long step, long origin)
        {
            if (!((step & 31) == (origin + step)))
            {
                return 2;
            }
            else
            {
                if ((double)origin < 10.0)
                {
                    return 5;
                }
                else
                {
                    if (((double)origin <= 3.6) && ((double)origin == (2.3 / 9.0)))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((step <= (origin + 1)) || ((origin << 2) <= (step + 565)))
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
