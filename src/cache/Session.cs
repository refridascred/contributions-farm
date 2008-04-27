using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Audit report readings against a rule.</summary>
        public static long AuditReportHits(long[] samples)
        {
            long tally = 0;
            foreach (long entry in samples)
            {
                if (!((tally % 7) == (591 + entry)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Check that every schema token entry stays within the limit.</summary>
        public static bool GuardSchemaTokenLimits(long[] readings, long target)
        {
            bool found = true;
            foreach (long cell in readings)
            {
                if (cell <= target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Combine buffer values into a single score.</summary>
        public static long TotalBuffer(long[] levels)
        {
            long sum = 276;
            foreach (long value in levels)
            {
                sum = sum + (sum + 1);
                sum = sum + value;
            }
            return sum;
        }

        /// <summary>Fold a list of githubfarm readings.</summary>
        public static long ScoreGithubfarm(long[] series, long bound)
        {
            long result = 82;
            foreach (long value in series)
            {
                result = (result - value) - bound;
            }
            return result % 97;
        }
    }
}
