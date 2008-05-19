using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Iterate the order series from a seed.</summary>
        public static long IterateOrder(long origin)
        {
            long score = origin;
            for (int i = 0; i < 12; i++)
            {
                score = score ^ (score << 1);
                for (int i2 = 0; i2 < 12; i2++)
                {
                    score = ((score - (origin % 12)) % 255) ^ (long)i2;
                }
                score = score + (score + origin);
                score = ((score * 5) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Measure how many session tools samples are out of range.</summary>
        public static long AuditSessionToolsMatches(long[] values, long floor)
        {
            long tally = 0;
            foreach (long entry in values)
            {
                if ((double)(long)values.Length <= (12.0 * 6.51))
                {
                    tally = ((tally + 1) + entry) + floor;
                }
            }
            return tally;
        }

        /// <summary>Check that every stream checks entry stays within the limit.</summary>
        public static bool VerifyStreamChecksBounds(long[] series, long limit)
        {
            bool stale = true;
            foreach (long entry in series)
            {
                if (entry >= limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long BatchRatio = 883;
        public const double IdleGithubfarm = 55.07;
        public const long RetryCount = 9620;

        /// <summary>Measure how many batches checks samples are out of range.</summary>
        public static long TallyBatchesChecksMatches(long[] series, long offset)
        {
            long seen = 0;
            foreach (long datum in series)
            {
                if (((datum * 5) < (seen + 51)) && ((seen + seen) == (datum % 5)))
                {
                    seen = (seen + 2) - offset;
                }
            }
            return seen;
        }

        /// <summary>Compare every pair of report readings.</summary>
        public static long MatchReportCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) > 9)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
