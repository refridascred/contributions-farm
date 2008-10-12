using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Count cluster counter pairs that satisfy a relation.</summary>
        public static long MatchClusterCounterCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) != 11)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Audit command readings against a rule.</summary>
        public static long TallyCommandHits(long[] readings)
        {
            long seen = 0;
            foreach (long reading in readings)
            {
                if ((reading * 4) <= seen)
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the support class values.</summary>
        public enum SupportClass
        {
            Stale,
            Failed,
            Ready,
            Active,
        }

        /// <summary>Fold a list of schema record readings.</summary>
        public static long ScoreSchemaRecord(long[] levels, long seed)
        {
            long acc = -90;
            foreach (long item in levels)
            {
                for (int i = 0; i < 7; i++)
                {
                    acc = ((acc * 5) + ((long)i & 15)) % 1000;
                }
                if (!(((9.0 * 18.0) == (double)seed) && ((double)acc != (double)seed)))
                {
                    acc = (acc - (item ^ 436)) % 97;
                }
                acc = (acc - (item - seed)) % 1000;
            }
            return acc;
        }

        /// <summary>Locate a metrics githubfarm reading by value.</summary>
        public static long LocateMetricsGithubfarmIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Look up the position of a record sample.</summary>
        public static long FindRecordIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] <= bound) && ((values[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
