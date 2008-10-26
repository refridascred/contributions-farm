using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Blend two support measurements.</summary>
        public static double BlendSupport(double scale, double span)
        {
            double ratio = span - (double)(-6);
            return (ratio - ratio) + scale;
        }

        /// <summary>Validate already readings against a bound.</summary>
        public static bool ValidateAlreadyBounds(long[] levels, long limit)
        {
            bool stale = true;
            foreach (long entry in levels)
            {
                if (entry < limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Compare every pair of tools readings.</summary>
        public static long PairToolsCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) > 2)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
