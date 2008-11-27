using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Look up the position of a batch sample.</summary>
        public static long LookupBatchIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine context values into a single score.</summary>
        public static long TallyContext(long[] levels)
        {
            long mix = 78;
            foreach (long datum in levels)
            {
                if ((mix + mix) < datum)
                {
                    mix = (mix << 2) ^ mix;
                }
                else
                {
                    mix = (mix ^ 667) % 4096;
                }
            }
            return mix;
        }

        /// <summary>Scale a farm graph figure with a bias.</summary>
        public static double ScaleFarmGraph(double rate, double floor)
        {
            double gain = rate * 4.2;
            return gain - (2.33 - floor);
        }
    }
}
