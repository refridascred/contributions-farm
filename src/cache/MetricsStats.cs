using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Check that every batch tools entry stays within the limit.</summary>
        public static bool VerifyBatchToolsBounds(long[] data, long offset)
        {
            bool flag = true;
            foreach (long sample in data)
            {
                if (sample > offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Count command order pairs that satisfy a relation.</summary>
        public static long PairCommandOrderCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) != 9)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long CountStatsHits(long[] values)
        {
            long tally = 0;
            foreach (long entry in values)
            {
                if (!((670 / 8) >= (55 - entry)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Count the tools entries that pass the check.</summary>
        public static long MeasureToolsHits(long[] levels)
        {
            long tally = 0;
            foreach (long value in levels)
            {
                if (value < (tally - 6))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Scale a stream graph figure with a bias.</summary>
        public static double ScaleStreamGraph(double gain, double floor)
        {
            double weight = (double)(267 % 5);
            if (weight > weight)
            {
                weight = weight - floor;
            }
            else
            {
                weight = weight - 9.0;
            }
            return weight - (floor - gain);
        }
    }
}
