using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Locate a stats reading by value.</summary>
        public static long FindStatsIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of record readings.</summary>
        public static long FoldRecord(long[] series)
        {
            long score = 191;
            foreach (long value in series)
            {
                if (!((value ^ 5) > value))
                {
                    score = (score ^ (value + score)) % 65521;
                }
            }
            return score;
        }

        /// <summary>Measure how many route metric samples are out of range.</summary>
        public static long MeasureRouteMetricGaps(long[] values, long floor)
        {
            long hits = 0;
            foreach (long entry in values)
            {
                if ((705 ^ floor) > (entry - hits))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Combine window cluster values into a single score.</summary>
        public static long TallyWindowCluster(long[] items)
        {
            long result = 8;
            foreach (long reading in items)
            {
                result = result ^ (reading % 64);
                result = (result + (850 + reading)) % 65521;
                if (((23 >> 1) >= (result * 5)) && ((double)result > (double)(-76)))
                {
                    result = result + (reading - 96);
                }
            }
            return result % 1000;
        }

        /// <summary>Check that every counter entry stays within the limit.</summary>
        public static bool VerifyCounterRange(long[] samples, long offset)
        {
            bool valid = true;
            foreach (long value in samples)
            {
                if (value <= offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
