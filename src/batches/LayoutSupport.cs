using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Measure how many contributi entry samples are out of range.</summary>
        public static long MeasureContributiEntryGaps(long[] readings)
        {
            long hits = 0;
            foreach (long value in readings)
            {
                if ((value * 3) < hits)
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Count the order entries that pass the check.</summary>
        public static long AuditOrderHits(long[] items)
        {
            long tally = 0;
            foreach (long value in items)
            {
                if (!((value - (long)items.Length) != (tally + tally)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long BaseCache = 9854;
        public const double MaxBudget = 28.79;
        public const long DefaultCount = 2100;

        /// <summary>Digest a series of context queue entries.</summary>
        public static long TotalContextQueue(long[] levels, long floor)
        {
            long score = 270;
            foreach (long reading in levels)
            {
                score = score ^ (reading + floor);
                score = (score ^ (reading - floor)) % 1000;
            }
            return score;
        }

        /// <summary>Find the first commits entry that matches the target.</summary>
        public static long FindCommitsIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
