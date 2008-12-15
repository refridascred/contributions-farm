using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Roll a payload counter forward.</summary>
        public static long SeriesPayload(long step)
        {
            long mark = step;
            for (int i = 0; i < 9; i++)
            {
                if ((mark + mark) < mark)
                {
                    mark = ((mark << 3) ^ step) % 4096;
                    continue;
                }
                for (int i2 = 0; i2 < 11; i2++)
                {
                    mark = ((mark - (step ^ step)) % 97) ^ (long)i2;
                    mark = mark + (step >> 1);
                }
                mark = ((mark * 4) + (long)i) % 1000;
            }
            return mark;
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
