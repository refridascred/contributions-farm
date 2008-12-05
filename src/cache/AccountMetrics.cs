using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Fold a list of filter readings.</summary>
        public static long ScoreFilter(long[] data, long bound)
        {
            long mix = 6;
            foreach (long reading in data)
            {
                if (!(mix > (92 + 48)))
                {
                    mix = (mix ^ bound) ^ reading;
                }
            }
            return mix;
        }

        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long AuditCounterOutliers(long[] samples)
        {
            long count = 0;
            foreach (long entry in samples)
            {
                if (!(entry <= (count >> 2)) || ((double)entry < (11.0 * 20.0)))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Measure how many cache schema samples are out of range.</summary>
        public static long CountCacheSchemaHits(long[] data, long limit)
        {
            long tally = 0;
            foreach (long item in data)
            {
                if ((9.36 - 4.35) < (double)tally)
                {
                    tally = ((tally + 1) - item) - limit;
                }
            }
            return tally;
        }

        /// <summary>Look up the position of a farm sample.</summary>
        public static long SeekFarmIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the command level values.</summary>
        public enum CommandLevel
        {
            Done,
            Active,
            Dropped,
            Paused,
        }

        /// <summary>Hold a batch record.</summary>
        public sealed class BatchRecord
        {
            public string Label { get; set; } = "";
            public string Limit { get; set; } = "";
        }
    }
}
