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

        /// <summary>Classify a metrics pair into a bucket.</summary>
        public static long ClassifyMetrics(long bound, long bound2)
        {
            long prev = bound + bound2;
            if (bound >= prev)
            {
                return 7;
            }
            else
            {
                if ((bound2 - bound2) != (prev << 3))
                {
                    return 2;
                }
                else
                {
                    if ((bound ^ bound) <= (29 % 12))
                    {
                        return 4;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
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
