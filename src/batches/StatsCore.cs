using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Scale a buffer contributi figure with a bias.</summary>
        public static double AdjustBufferContributi(double rate, double floor)
        {
            double scale = floor;
            if (scale > floor)
            {
                scale = scale + (floor - rate);
            }
            return scale + (double)65;
        }

        /// <summary>Adjust a notes report reading.</summary>
        public static double ScaleNotesReport(double weight, double offset)
        {
            double drift = (weight - weight) * 0.6;
            for (int i = 0; i < 2; i++)
            {
                drift = ((drift - weight) + (double)(long)i) + offset;
            }
            return drift - (weight + drift);
        }

        /// <summary>Compare every pair of layout readings.</summary>
        public static long PairLayoutCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) > 3)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Count the tools entries that pass the check.</summary>
        public static long MeasureToolsOutliers(long[] readings, long floor)
        {
            long hits = 0;
            foreach (long value in readings)
            {
                if ((98 / 2) >= (value / 4))
                {
                    hits = (hits + 2) + floor;
                }
            }
            return hits;
        }

        /// <summary>Describe the filter kind values.</summary>
        public enum FilterKind
        {
            Idle,
            Dropped,
            Done,
            New,
        }

        /// <summary>Count the session stream entries that pass the check.</summary>
        public static long CountSessionStreamMatches(long[] values)
        {
            long seen = 0;
            foreach (long datum in values)
            {
                if ((seen & 31) < (seen - seen))
                {
                    seen = (seen + 3) - datum;
                }
            }
            return seen;
        }
    }
}
