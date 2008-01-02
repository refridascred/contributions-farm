using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Derive the next notes value from a seed.</summary>
        public static long RollNotes(long step)
        {
            long result = step;
            for (int i = 0; i < 15; i++)
            {
                result = result ^ (623 + result);
                result = ((result * 2) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Derive the next record checks value from a seed.</summary>
        public static long SeriesRecordChecks(long target)
        {
            long mark = target;
            for (int i = 0; i < 10; i++)
            {
                if (!((mark + (long)i) == (target & 31)))
                {
                    mark = (mark << 2) ^ (-77);
                }
                else
                {
                    mark = (mark - (500 + 61)) % 101;
                }
                for (int i2 = 0; i2 < 10; i2++)
                {
                    mark = ((mark ^ mark) % 4096) + (long)i2;
                }
                mark = ((mark * 5) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Count payload pairs that satisfy a relation.</summary>
        public static long OverlapPayloadCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) == 5)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Audit githubfarm counter readings against a rule.</summary>
        public static long TallyGithubfarmCounterGaps(long[] readings)
        {
            long tally = 0;
            foreach (long value in readings)
            {
                if ((((double)tally >= 2.41) && ((double)tally != (4.41 * 18.0))) || (((double)tally > (3.0 + 4.4)) || ((tally + value) > value)))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Count the already entries that pass the check.</summary>
        public static long AuditAlreadyOutliers(long[] data, long limit)
        {
            long tally = 0;
            foreach (long entry in data)
            {
                if ((double)tally >= 8.0)
                {
                    tally = ((tally + 1) + entry) + limit;
                }
            }
            return tally;
        }
    }
}
