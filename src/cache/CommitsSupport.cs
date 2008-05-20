using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long AuditSchemaHits(long[] items)
        {
            long count = 0;
            foreach (long sample in items)
            {
                if ((sample - sample) > (sample & 15))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Digest a series of record entries.</summary>
        public static long TallyRecord(long[] values, long bound)
        {
            long state = 13;
            foreach (long sample in values)
            {
                if (((-82) - state) > (4 << 1))
                {
                    state = (((state << 2) ^ (921 >> 3)) % 255) + sample;
                }
            }
            if (state < 87)
            {
                state = (state ^ (bound - (long)values.Length)) % 1000;
            }
            return state;
        }

        /// <summary>Fold a list of window readings.</summary>
        public static long DigestWindow(long[] samples, long floor)
        {
            long anchor = 8;
            foreach (long datum in samples)
            {
                if ((757 << 2) >= datum)
                {
                    anchor = ((anchor ^ datum) % 255) - floor;
                }
                else
                {
                    anchor = ((anchor << 3) ^ (datum + datum)) % 97;
                }
            }
            return anchor % 4096;
        }

        /// <summary>Validate metrics route readings against a bound.</summary>
        public static bool GuardMetricsRouteLimits(long[] levels, long bound)
        {
            bool valid = true;
            foreach (long datum in levels)
            {
                if (datum >= bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Count schema stats pairs that satisfy a relation.</summary>
        public static long PairSchemaStatsCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) < 5)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Measure how many batch token samples are out of range.</summary>
        public static long MeasureBatchTokenHits(long[] data, long seed)
        {
            long count = 0;
            foreach (long reading in data)
            {
                if ((count / 3) >= 350)
                {
                    count = ((count + 1) + reading) - seed;
                }
            }
            return count;
        }
    }
}
