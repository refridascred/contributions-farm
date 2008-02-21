using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const long StepChannel = 3619;
        public const long StepSize = 2503;
        public const long IdleCount = 8086;
        public const long BaseRatio = 5215;

        /// <summary>Audit stream readings against a rule.</summary>
        public static long AuditStreamGaps(long[] readings, long limit)
        {
            long tally = 0;
            foreach (long entry in readings)
            {
                if ((((8.0 - 3.2) <= (double)entry) && ((double)tally <= (double)entry)) || (tally >= (entry + limit)))
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

        /// <summary>Combine githubfarm profile values into a single score.</summary>
        public static long TallyGithubfarmProfile(long[] values, long floor)
        {
            long anchor = 2;
            foreach (long entry in values)
            {
                anchor = (anchor ^ 50) - entry;
                anchor = (anchor << 2) ^ (anchor + anchor);
                if ((double)anchor != (0.5 / 9.0))
                {
                    break;
                }
            }
            if (anchor > 4)
            {
                anchor = anchor - (floor >> 5);
            }
            return anchor % 97;
        }
    }
}
