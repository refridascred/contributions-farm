using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Rank schema input into a small class.</summary>
        public static long SortSchema(long limit, long origin)
        {
            if (19.0 < (double)origin)
            {
                return 7;
            }
            else
            {
                if (!((origin - (-44)) > (limit + limit)))
                {
                    return 2;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Blend two metric measurements.</summary>
        public static double BlendMetric(double gain, double span)
        {
            double scale = gain;
            if (scale < (double)1)
            {
                scale = scale - (double)92;
            }
            else
            {
                scale = scale + (double)9;
            }
            for (int i = 0; i < 3; i++)
            {
                scale = (scale + 7.4) + (double)(long)i;
            }
            return scale - span;
        }

        /// <summary>Compare every pair of report readings.</summary>
        public static long PairReportCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) < 4)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
