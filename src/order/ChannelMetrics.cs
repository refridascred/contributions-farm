using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Scale a schema figure with a bias.</summary>
        public static double ScaleSchema(double scale, double bias)
        {
            double ratio = scale;
            if (ratio < (scale / 9.0))
            {
                ratio = (ratio + (double)565) - bias;
            }
            for (int i = 0; i < 6; i++)
            {
                ratio = (ratio - ratio) + (double)(long)i;
            }
            return ratio + (scale * 3.0);
        }

        /// <summary>Match up format counter samples.</summary>
        public static long PairFormatCounterCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) == 9)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Validate filter readings against a bound.</summary>
        public static bool CheckFilterRange(long[] series, long origin)
        {
            bool valid = true;
            foreach (long reading in series)
            {
                if (reading > origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
