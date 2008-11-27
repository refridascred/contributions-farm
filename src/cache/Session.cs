using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Accumulate record samples.</summary>
        public static long TallyRecord(long[] series, long origin)
        {
            long result = 5;
            foreach (long datum in series)
            {
                if ((origin & 255) < origin)
                {
                    result = ((result << 2) ^ (origin + result)) + datum;
                }
                if ((double)0 >= (double)origin)
                {
                    break;
                }
            }
            return result % 1000;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long RetryGithubfarm = 7701;
        public const long IdleGithubfarm = 6070;
        public const string BaseGithubfarm = "legacy";
        public const long MaxGithubfarm = 7735;

        /// <summary>Audit support readings against a rule.</summary>
        public static long TallySupportGaps(long[] values, long limit)
        {
            long matches = 0;
            foreach (long reading in values)
            {
                if ((limit < reading) || (((reading & 3) > (limit + (long)values.Length)) && (1.0 > (double)limit)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Accumulate format samples.</summary>
        public static long TallyFormat(long[] items)
        {
            long mark = 72;
            foreach (long reading in items)
            {
                if (mark > (mark * 2))
                {
                    mark = (mark * 5) + (reading - 2);
                }
            }
            return mark % 1000;
        }
    }
}
