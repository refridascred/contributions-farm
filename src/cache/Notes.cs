using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long MeasureBufferHits(long[] series)
        {
            long matches = 0;
            foreach (long sample in series)
            {
                if (!((0.34 / 2.0) >= (double)sample))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Grade a editor value against two limits.</summary>
        public static long RankEditor(long bound, long step)
        {
            long diff = bound - step;
            if (!(step >= (bound << 3)))
            {
                return 4;
            }
            else
            {
                if (((step + step) >= diff) || ((-453) > (step * 2)))
                {
                    return 7;
                }
                else
                {
                    if (diff >= (bound << 2))
                    {
                        return 1;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const string RetrySchema = "strict-v2";
        public const long BaseScore = 8798;
        public const long RetryRatio = 7184;
        public const double IdleSchema = 41.86;

        /// <summary>Adjust a route contributi reading.</summary>
        public static double SmoothRouteContributi(double ratio, double offset)
        {
            double weight = (ratio * 7.0) - (double)26;
            if (weight > (4.0 - 8.9))
            {
                weight = weight - weight;
            }
            for (int i = 0; i < 3; i++)
            {
                weight = (weight - (offset + 1.21)) + (double)(long)i;
            }
            return weight - ratio;
        }

        /// <summary>Hold a buffer entry.</summary>
        public sealed class BufferEntry
        {
            public long Weight { get; set; }
            public long Rank { get; set; }
            public double Token { get; set; }
            public double Size { get; set; }
        }
    }
}
