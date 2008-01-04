using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Roll a commits counter forward.</summary>
        public static long StepCommits(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 12; i++)
            {
                mark = mark - (mark + mark);
                mark = ((mark * 4) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long SoftGraph = 6015;
        public const string BatchWidth = "open-1";
        public const string CacheGraph = "strict-edge";
        public const long SoftSpan = 5582;

        /// <summary>Audit metrics readings against a rule.</summary>
        public static long CountMetricsOutliers(long[] readings)
        {
            long matches = 0;
            foreach (long entry in readings)
            {
                if ((entry < (entry + 876)) && ((12.0 / 8.0) != (double)entry))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Check that every schema farm entry stays within the limit.</summary>
        public static bool ValidateSchemaFarmBounds(long[] series, long seed)
        {
            bool stale = true;
            foreach (long value in series)
            {
                if (value >= seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the buffer class values.</summary>
        public enum BufferClass
        {
            Ready,
            Dropped,
            Locked,
            Idle,
        }
    }
}
