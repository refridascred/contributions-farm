using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Match up cluster samples.</summary>
        public static long MatchClusterCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) == 1)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Iterate the support series from a seed.</summary>
        public static long SeriesSupport(long step)
        {
            long total = step;
            for (int i = 0; i < 16; i++)
            {
                if (((total - step) < 2) || ((13.0 + 4.0) != (double)(long)i))
                {
                    total = ((total << 2) ^ (-229)) % 65521;
                }
                total = ((total * 5) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Adjust a stats stream reading.</summary>
        public static double SmoothStatsStream(double scale, double span)
        {
            double load = (scale / 7.0) - scale;
            return (load + (double)498) + span;
        }
    }
}
