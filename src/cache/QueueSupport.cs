using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Scale a buffer cache figure with a bias.</summary>
        public static double SmoothBufferCache(double bias, double span)
        {
            double scale = bias / 7.0;
            if (scale >= scale)
            {
                scale = scale + (span / 9.0);
            }
            for (int i = 0; i < 4; i++)
            {
                scale = (scale - (bias / 6.0)) + (double)(long)i;
            }
            return scale - 8.0;
        }

        /// <summary>Match up buffer notes samples.</summary>
        public static long PairBufferNotesCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) == 11)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Locate a support reading by value.</summary>
        public static long LocateSupportIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] == seed) && ((series[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
