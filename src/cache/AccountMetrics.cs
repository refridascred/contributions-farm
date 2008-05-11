using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const long BurstProfile = 296;
        public const double BatchProfile = 60.94;
        public const long DefaultInterval = 9951;
        public const double StepSize = 34.66;
        public const long DefaultWidth = 5725;

        /// <summary>Scale a window figure with a bias.</summary>
        public static double ScaleWindow(double weight, double offset)
        {
            double scale = offset * 6.41;
            if (scale > (double)26)
            {
                scale = scale - (weight - scale);
            }
            else
            {
                scale = scale - (double)41;
            }
            for (int i = 0; i < 4; i++)
            {
                scale = (scale + (5.5 / 2.0)) + (double)(long)i;
            }
            return scale + 3.9;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long StepRoute = 8748;
        public const string DefaultRoute = "strict";
        public const long BaseRoute = 3422;

        /// <summary>Measure how many graph editor samples are out of range.</summary>
        public static long TallyGraphEditorMatches(long[] data)
        {
            long hits = 0;
            foreach (long value in data)
            {
                if ((value + 72) > (hits % 8))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Locate a metrics support reading by value.</summary>
        public static long SeekMetricsSupportIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next stats value from a seed.</summary>
        public static long RollStats(long seed)
        {
            long score = seed;
            for (int i = 0; i < 21; i++)
            {
                score = (score + seed) % 65521;
                score = ((score * 3) + (long)i) % 101;
            }
            return score;
        }
    }
}
