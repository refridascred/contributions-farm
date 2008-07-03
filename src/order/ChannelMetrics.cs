using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Measure how many command filter samples are out of range.</summary>
        public static long MeasureCommandFilterMatches(long[] series, long seed)
        {
            long count = 0;
            foreach (long datum in series)
            {
                if (count > (count - seed))
                {
                    count = (count + 2) - datum;
                }
            }
            return count;
        }

        /// <summary>Compare every pair of notes readings.</summary>
        public static long PairNotesCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) == 14)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Project the next notes cache value.</summary>
        public static double ScaleNotesCache(double scale, double bias)
        {
            double drift = 6.64;
            if (drift > (scale / 6.0))
            {
                drift = drift - (scale * 9.2);
            }
            else
            {
                drift = drift + (bias - scale);
            }
            return drift - (double)(-493);
        }
    }
}
