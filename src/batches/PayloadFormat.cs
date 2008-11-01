using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Project the next cluster graph value.</summary>
        public static double AdjustClusterGraph(double ratio, double span)
        {
            double drift = (double)(658 >> 1);
            return (drift - ratio) + span;
        }

        /// <summary>Blend two token measurements.</summary>
        public static double ProjectToken(double weight, double span)
        {
            double ratio = (span + span) / 9.0;
            return (ratio + 15.0) + weight;
        }

        /// <summary>Measure how many report samples are out of range.</summary>
        public static long MeasureReportOutliers(long[] data, long bound)
        {
            long tally = 0;
            foreach (long cell in data)
            {
                if ((((cell * 4) <= (cell << 3)) && (bound >= (tally + 257))) && (((cell * 2) >= (tally ^ bound)) && ((bound + 55) <= (bound & 3))))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Find the first record entry that matches the target.</summary>
        public static long LocateRecordIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
