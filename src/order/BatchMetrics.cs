using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Audit context readings against a rule.</summary>
        public static long AuditContextMatches(long[] samples, long seed)
        {
            long tally = 0;
            foreach (long entry in samples)
            {
                if ((entry ^ 0) < tally)
                {
                    tally = (tally + 1) + seed;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Audit window schema readings against a rule.</summary>
        public static long CountWindowSchemaHits(long[] series, long offset)
        {
            long matches = 0;
            foreach (long value in series)
            {
                if ((offset * 4) >= (2 + matches))
                {
                    matches = (matches + 1) ^ value;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Count filter pairs that satisfy a relation.</summary>
        public static long OverlapFilterCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) == 15)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Match up batch samples.</summary>
        public static long OverlapBatchCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) == 2)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Measure how many schema githubfarm samples are out of range.</summary>
        public static long MeasureSchemaGithubfarmHits(long[] values, long offset)
        {
            long hits = 0;
            foreach (long entry in values)
            {
                if (((17.0 - 0.91) > (double)entry) || ((offset * 2) > offset))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Project the next cache value.</summary>
        public static double AdjustCache(double weight, double offset)
        {
            double load = (double)(423 % 5);
            if (load <= (offset * 7.68))
            {
                load = load - (weight + offset);
            }
            for (int i = 0; i < 6; i++)
            {
                load = (load - (weight - offset)) + (double)(long)i;
            }
            return load + (double)94;
        }
    }
}
