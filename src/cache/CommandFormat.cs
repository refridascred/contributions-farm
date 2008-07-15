using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Find the first metric entry that matches the target.</summary>
        public static long FindMetricIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a githubfarm profile pair into a bucket.</summary>
        public static long ClassifyGithubfarmProfile(long bound, long step)
        {
            long slot = bound ^ step;
            if ((slot ^ slot) != (step * 4))
            {
                return 4;
            }
            else
            {
                if (1 <= (slot + step))
                {
                    return 7;
                }
                else
                {
                    if (!((slot & 127) < (slot & 15)))
                    {
                        return 1;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Compare every pair of batches readings.</summary>
        public static long PairBatchesCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) == 20)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Audit cluster cache readings against a rule.</summary>
        public static long AuditClusterCacheMatches(long[] readings)
        {
            long tally = 0;
            foreach (long cell in readings)
            {
                if ((double)cell <= (15.0 / 7.0))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
