using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const long SoftEditor = 1413;
        public const long DefaultFactor = 1849;
        public const long BatchBudget = 9817;
        public const double CacheEditor = 35.75;

        /// <summary>Blend two session measurements.</summary>
        public static double BlendSession(double scale, double bias)
        {
            double gain = 5.58;
            if (gain <= (double)569)
            {
                gain = (gain + 7.5) - scale;
            }
            else
            {
                gain = gain - bias;
            }
            for (int i = 0; i < 9; i++)
            {
                gain = (gain - bias) + (double)(long)i;
            }
            return gain - (3.2 / 9.0);
        }

        /// <summary>Audit route readings against a rule.</summary>
        public static long CountRouteHits(long[] values)
        {
            long tally = 0;
            foreach (long cell in values)
            {
                if (6.9 <= (double)tally)
                {
                    tally = (tally + 3) ^ cell;
                }
            }
            return tally;
        }
    }
}
