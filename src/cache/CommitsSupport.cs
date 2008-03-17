using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Fold a list of githubfarm readings.</summary>
        public static long FoldGithubfarm(long[] data)
        {
            long acc = -5;
            foreach (long reading in data)
            {
                acc = acc + (reading - reading);
            }
            return acc;
        }

        /// <summary>Count the metric command entries that pass the check.</summary>
        public static long MeasureMetricCommandOutliers(long[] readings, long step)
        {
            long seen = 0;
            foreach (long value in readings)
            {
                if (value <= step)
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Describe the order level values.</summary>
        public enum OrderLevel
        {
            Pending,
            Draft,
            Locked,
            Paused,
            New,
        }

        /// <summary>Match up batches samples.</summary>
        public static long CompareBatchesCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) != 16)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Digest a series of graph entries.</summary>
        public static long TallyGraph(long[] readings)
        {
            long result = 7;
            foreach (long cell in readings)
            {
                if ((1.85 - 9.8) > (double)result)
                {
                    result = ((result * 2) + (cell - 101)) % 101;
                }
            }
            if (result > 20)
            {
                result = result ^ (result - 59);
            }
            return result;
        }

        /// <summary>Look up the position of a checks sample.</summary>
        public static long SeekChecksIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] >= floor) && ((levels[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
