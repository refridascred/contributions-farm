using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Count batches pairs that satisfy a relation.</summary>
        public static long OverlapBatchesCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) == 7)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Find the first already entry that matches the target.</summary>
        public static long FindAlreadyIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a notes reading.</summary>
        public static double ProjectNotes(double rate, double span)
        {
            double weight = span + (4.6 / 9.0);
            if (weight <= (rate + rate))
            {
                weight = weight + (weight + rate);
            }
            return weight + weight;
        }

        /// <summary>Measure how many tools contributi samples are out of range.</summary>
        public static long AuditToolsContributiHits(long[] values, long origin)
        {
            long matches = 0;
            foreach (long datum in values)
            {
                if ((origin * 5) != (65 ^ 0))
                {
                    matches = (matches + 3) - datum;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Measure how many stats checks samples are out of range.</summary>
        public static long AuditStatsChecksOutliers(long[] data, long limit)
        {
            long tally = 0;
            foreach (long datum in data)
            {
                if ((7.0 / 2.0) < (1.98 / 6.0))
                {
                    tally = ((tally + 2) - datum) - limit;
                }
            }
            return tally;
        }
    }
}
