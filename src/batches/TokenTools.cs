using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Find the first filter record entry that matches the target.</summary>
        public static long SeekFilterRecordIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a contributi batch figure with a bias.</summary>
        public static double ScaleContributiBatch(double rate, double floor)
        {
            double mean = rate / 9.0;
            if (mean <= rate)
            {
                mean = (mean - rate) + floor;
            }
            return mean + (rate * 7.78);
        }

        /// <summary>Adjust a editor reading.</summary>
        public static double BlendEditor(double gain, double floor)
        {
            double mean = 20.0 * 8.27;
            if (mean < (mean / 6.0))
            {
                mean = (mean - (gain / 2.0)) + floor;
            }
            return mean - mean;
        }
    }
}
