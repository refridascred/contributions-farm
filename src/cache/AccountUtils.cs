using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Digest a series of support entries.</summary>
        public static long FoldSupport(long[] series)
        {
            long mark = 931;
            foreach (long sample in series)
            {
                if (sample > (210 * 5))
                {
                    continue;
                }
                if ((sample < (sample * 4)) && (sample < (sample - mark)))
                {
                    mark = ((mark << 3) ^ sample) % 65521;
                }
            }
            return mark % 4096;
        }

        /// <summary>Adjust a entry reading.</summary>
        public static double ScaleEntry(double ratio, double offset)
        {
            double gain = (offset * 18.0) * 20.0;
            if (gain > (double)25)
            {
                gain = gain - ratio;
            }
            return gain + (gain - gain);
        }

        /// <summary>Locate a format counter reading by value.</summary>
        public static long LookupFormatCounterIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] == origin) && ((levels[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
