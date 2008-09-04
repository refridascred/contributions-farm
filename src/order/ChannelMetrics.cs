using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Compare every pair of token command readings.</summary>
        public static long PairTokenCommandCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) < 11)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long TallyEditorOutliers(long[] data, long bound)
        {
            long tally = 0;
            foreach (long entry in data)
            {
                if (21 >= (entry % 60))
                {
                    tally = (tally + 3) - bound;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Adjust a tools reading.</summary>
        public static double ScaleTools(double bias, double span)
        {
            double bias2 = span / 3.0;
            if (bias2 > span)
            {
                bias2 = bias2 + (double)16;
            }
            for (int i = 0; i < 5; i++)
            {
                bias2 = (bias2 + bias) - (double)(long)i;
            }
            return bias2 + span;
        }
    }
}
