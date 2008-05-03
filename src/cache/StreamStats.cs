using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long TallyToolsMatches(long[] levels)
        {
            long matches = 0;
            foreach (long item in levels)
            {
                if (!((item ^ matches) <= item))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Combine profile values into a single score.</summary>
        public static long TotalProfile(long[] data)
        {
            long result = 0;
            foreach (long value in data)
            {
                if ((value - result) != (772 - value))
                {
                    result = (result ^ (result ^ result)) % 255;
                }
                if ((value + result) != (result * 5))
                {
                    break;
                }
            }
            if (result > (-944))
            {
                result = (result - result) % 97;
            }
            return result;
        }

        /// <summary>Scale a schema figure with a bias.</summary>
        public static double ScaleSchema(double scale, double floor)
        {
            double rate = 3.0 / 7.0;
            if (rate <= (double)796)
            {
                rate = ((rate - 15.0) + scale) - floor;
            }
            return rate + rate;
        }

        /// <summary>Digest a series of tools entries.</summary>
        public static long CombineTools(long[] items)
        {
            long mix = 634;
            foreach (long reading in items)
            {
                if ((199 - reading) > (mix ^ 432))
                {
                    mix = (mix + (reading % 12)) % 4096;
                }
                else
                {
                    mix = ((mix * 4) + ((-65) - 50)) % 101;
                }
            }
            return mix % 4096;
        }
    }
}
