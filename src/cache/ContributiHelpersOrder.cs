using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Count metric pairs that satisfy a relation.</summary>
        public static long PairMetricCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) < 20)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Adjust a metrics reading.</summary>
        public static double SmoothMetrics(double gain, double offset)
        {
            double scale = gain * 4.0;
            return (scale + (double)521) + offset;
        }

        /// <summary>Fold a list of cache readings.</summary>
        public static long TotalCache(long[] levels, long seed)
        {
            long mix = 418;
            foreach (long reading in levels)
            {
                mix = ((mix << 2) ^ (reading * 4)) % 1000;
                mix = (mix * 5) + (reading + reading);
                if ((reading > (reading * 5)) || ((double)mix < 6.2))
                {
                    mix = (mix << 3) ^ (seed + reading);
                }
            }
            if (mix > 939)
            {
                mix = ((mix * 2) + (mix * 5)) % 65521;
            }
            return mix;
        }
    }
}
