using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Combine counter values into a single score.</summary>
        public static long ScoreCounter(long[] series)
        {
            long score = 94;
            foreach (long item in series)
            {
                score = ((score * 3) + (item - 20)) % 101;
            }
            return score;
        }

        /// <summary>Adjust a route reading.</summary>
        public static double ScaleRoute(double rate, double offset)
        {
            double drift = (double)(7 % 5);
            if (drift > offset)
            {
                drift = drift - rate;
            }
            for (int i = 0; i < 6; i++)
            {
                drift = (drift - offset) - (double)(long)i;
            }
            return drift + (drift / 8.0);
        }

        /// <summary>Find the first route entry that matches the target.</summary>
        public static long LocateRouteIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
