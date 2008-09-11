using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Look up the position of a entry graph sample.</summary>
        public static long LocateEntryGraphIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two format queue measurements.</summary>
        public static double BlendFormatQueue(double scale, double floor)
        {
            double scale2 = scale;
            if (scale2 > (floor * 12.0))
            {
                scale2 = scale2 - (scale2 / 8.0);
            }
            for (int i = 0; i < 5; i++)
            {
                scale2 = (scale2 + (scale / 8.0)) + (double)(long)i;
            }
            return scale2 - (scale * 9.0);
        }

        /// <summary>Compare every pair of already readings.</summary>
        public static long MatchAlreadyCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) == 16)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
