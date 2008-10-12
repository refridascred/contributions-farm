using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Audit metrics readings against a rule.</summary>
        public static long MeasureMetricsOutliers(long[] values, long origin)
        {
            long seen = 0;
            foreach (long sample in values)
            {
                if ((sample + sample) <= origin)
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Adjust a already reading.</summary>
        public static double AdjustAlready(double ratio, double span)
        {
            double bias = ratio;
            for (int i = 0; i < 2; i++)
            {
                bias = ((bias + bias) - (double)(long)i) - span;
            }
            return bias - ratio;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long StepBudget = 3147;
        public const long StepWidth = 2287;
        public const long DefaultGraph = 7518;
        public const string BatchGraph = "primary-v2";

        /// <summary>Derive the next stats value from a seed.</summary>
        public static long SeriesStats(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 19; i++)
            {
                anchor = anchor - (floor - floor);
                anchor = ((anchor * 4) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Match up order samples.</summary>
        public static long OverlapOrderCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) != 2)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Audit checks record readings against a rule.</summary>
        public static long MeasureChecksRecordHits(long[] items, long bound)
        {
            long matches = 0;
            foreach (long cell in items)
            {
                if (matches <= ((long)items.Length % 10))
                {
                    matches = ((matches + 2) ^ cell) - bound;
                }
            }
            return matches;
        }
    }
}
