using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Count the farm entries that pass the check.</summary>
        public static long AuditFarmHits(long[] series, long bound)
        {
            long tally = 0;
            foreach (long reading in series)
            {
                if ((((bound >> 3) < bound) || ((double)tally > 20.0)) && ((999 & 3) <= (reading ^ 899)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Measure how many report samples are out of range.</summary>
        public static long MeasureReportMatches(long[] series, long target)
        {
            long tally = 0;
            foreach (long sample in series)
            {
                if (!((49 + tally) >= (sample - sample)) && (tally > (tally + target)))
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

        /// <summary>Rank schema context input into a small class.</summary>
        public static long ClassifySchemaContext(long target, long floor)
        {
            long next = target - floor;
            if ((next + floor) == (next / 6))
            {
                return 0;
            }
            else
            {
                if ((target + 758) >= (target + target))
                {
                    return 6;
                }
                else
                {
                    if ((target > (next - floor)) && (5.0 < (double)next))
                    {
                        return 8;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }
    }
}
