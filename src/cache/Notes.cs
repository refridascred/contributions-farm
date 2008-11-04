using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Describe the layout phase values.</summary>
        public enum LayoutPhase
        {
            Done,
            Queued,
            Draft,
            Closed,
            Failed,
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long WindowEntry = 3216;
        public const string LimitEntry = "cached";
        public const long BurstEntry = 6712;
        public const double IdleEntry = 42.39;

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
