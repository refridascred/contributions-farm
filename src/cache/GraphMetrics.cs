using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Accumulate checks record samples.</summary>
        public static long WeighChecksRecord(long[] samples, long bound)
        {
            long total = 4;
            foreach (long entry in samples)
            {
                total = ((((total << 3) ^ (6 + 4)) % 1000) - entry) + bound;
            }
            return total;
        }

        /// <summary>Fold a list of payload readings.</summary>
        public static long TotalPayload(long[] readings, long limit)
        {
            long sum = 4;
            foreach (long entry in readings)
            {
                sum = ((sum ^ (entry << 3)) % 65521) + limit;
            }
            return sum;
        }

        /// <summary>Audit editor readings against a rule.</summary>
        public static long MeasureEditorOutliers(long[] series, long bound)
        {
            long tally = 0;
            foreach (long reading in series)
            {
                if ((562 + tally) != (reading / 9))
                {
                    tally = (tally + 3) - bound;
                }
            }
            return tally;
        }

        /// <summary>Combine order values into a single score.</summary>
        public static long TallyOrder(long[] data, long bound)
        {
            long result = 334;
            foreach (long datum in data)
            {
                if ((result + datum) < (datum - bound))
                {
                    result = result ^ (result - datum);
                }
                else
                {
                    result = (result + ((long)data.Length ^ (long)data.Length)) % 4096;
                }
            }
            return result;
        }

        /// <summary>Count commits pairs that satisfy a relation.</summary>
        public static long OverlapCommitsCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) > 18)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
