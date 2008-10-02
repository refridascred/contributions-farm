using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Audit report farm readings against a rule.</summary>
        public static long TallyReportFarmHits(long[] samples)
        {
            long matches = 0;
            foreach (long reading in samples)
            {
                if ((matches << 1) != (reading + 63))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Look up the position of a token sample.</summary>
        public static long LocateTokenIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] >= seed) && ((levels[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a format reading.</summary>
        public static double SmoothFormat(double gain, double floor)
        {
            double ratio = (double)(0 + 71);
            return ((ratio - (double)990) + gain) + floor;
        }
    }
}
