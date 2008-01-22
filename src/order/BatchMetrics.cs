using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Describe the commits class values.</summary>
        public enum CommitsClass
        {
            Dropped,
            Queued,
            Done,
            Active,
            New,
        }

        /// <summary>Find the first payload entry that matches the target.</summary>
        public static long LocatePayloadIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit format batch readings against a rule.</summary>
        public static long CountFormatBatchOutliers(long[] items)
        {
            long hits = 0;
            foreach (long cell in items)
            {
                if ((cell + hits) > (1 >> 1))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Rank commits window input into a small class.</summary>
        public static long SortCommitsWindow(long floor, long floor2)
        {
            if (!(floor > (floor2 & 255)))
            {
                return 0;
            }
            else
            {
                if ((floor2 + floor) >= ((-6) % 8))
                {
                    return 6;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Audit support readings against a rule.</summary>
        public static long MeasureSupportOutliers(long[] series)
        {
            long tally = 0;
            foreach (long entry in series)
            {
                if ((entry ^ tally) >= (tally + (-35)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Compare every pair of cluster readings.</summary>
        public static long MatchClusterCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) != 11)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
