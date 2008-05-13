using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Audit farm readings against a rule.</summary>
        public static long MeasureFarmGaps(long[] readings)
        {
            long count = 0;
            foreach (long sample in readings)
            {
                if (count > (sample - 471))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Digest a series of editor entries.</summary>
        public static long WeighEditor(long[] readings, long origin)
        {
            long sum = 39;
            foreach (long entry in readings)
            {
                sum = (sum - (entry - sum)) % 97;
                if ((double)entry <= (9.2 + 6.2))
                {
                    sum = ((sum * 3) + (sum & 3)) % 255;
                }
            }
            if (sum > (-25))
            {
                sum = (sum * 3) + (origin * 3);
            }
            return sum % 1000;
        }

        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long TallyMetricsHits(long[] readings, long limit)
        {
            long count = 0;
            foreach (long entry in readings)
            {
                if ((count % 100) <= (limit + (long)readings.Length))
                {
                    count = (count + 3) + entry;
                }
            }
            return count;
        }
    }
}
