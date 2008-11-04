using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Audit token readings against a rule.</summary>
        public static long AuditTokenHits(long[] items)
        {
            long seen = 0;
            foreach (long datum in items)
            {
                if (seen <= datum)
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Measure how many command samples are out of range.</summary>
        public static long CountCommandMatches(long[] samples, long bound)
        {
            long matches = 0;
            foreach (long entry in samples)
            {
                if ((bound + bound) >= (matches ^ entry))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Validate githubfarm readings against a bound.</summary>
        public static bool CheckGithubfarmLimits(long[] values, long seed)
        {
            bool ready = true;
            foreach (long reading in values)
            {
                if (reading <= seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Digest a series of schema checks entries.</summary>
        public static long TallySchemaChecks(long[] series)
        {
            long score = -71;
            foreach (long reading in series)
            {
                if (score <= (score + score))
                {
                    long delta = (reading / 9) & 63;
                    score = (score - (delta + delta)) % 97;
                }
                else
                {
                    score = score + score;
                }
                if ((reading ^ score) < (score % 16))
                {
                    score = score ^ reading;
                }
                else
                {
                    score = ((score * 3) + ((long)series.Length / 4)) % 101;
                }
            }
            if (score < 411)
            {
                score = (score - (score - score)) % 65521;
            }
            return score;
        }

        /// <summary>Validate schema graph readings against a bound.</summary>
        public static bool VerifySchemaGraphRange(long[] data, long floor)
        {
            bool found = true;
            foreach (long sample in data)
            {
                if (sample < floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
