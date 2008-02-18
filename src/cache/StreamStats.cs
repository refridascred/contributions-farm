using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long MeasureBatchGaps(long[] series, long target)
        {
            long hits = 0;
            foreach (long item in series)
            {
                if ((item << 3) < (target % 60))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Project the next cluster value.</summary>
        public static double AdjustCluster(double rate, double span)
        {
            double gain = rate;
            if (gain <= rate)
            {
                gain = gain - (span / 3.0);
            }
            else
            {
                gain = gain - gain;
            }
            return gain + (1.65 / 5.0);
        }

        /// <summary>Find the first record entry that matches the target.</summary>
        public static long FindRecordIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Compare every pair of stream report readings.</summary>
        public static long MatchStreamReportCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) > 20)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
