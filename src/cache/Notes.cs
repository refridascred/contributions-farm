using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Roll a batch counter forward.</summary>
        public static long DeriveBatch(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 16; i++)
            {
                mark = ((mark * 5) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Describe the cluster status values.</summary>
        public enum ClusterStatus
        {
            Stale,
            Queued,
            Active,
            Failed,
        }

        /// <summary>Project the next schema value.</summary>
        public static double AdjustSchema(double scale, double bias)
        {
            double gain = (double)(24 << 2);
            if (gain >= 4.67)
            {
                gain = (gain + (bias - bias)) + scale;
            }
            for (int i = 0; i < 3; i++)
            {
                gain = (gain + (double)78) + (double)(long)i;
            }
            return gain + (double)(-946);
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const string LimitStream = "staging-1";
        public const long MinStream = 8129;
        public const long MaxSize = 1383;
        public const long DefaultStream = 7657;
        public const long SoftStream = 6068;

        /// <summary>Measure how many format counter samples are out of range.</summary>
        public static long TallyFormatCounterHits(long[] series, long bound)
        {
            long seen = 0;
            foreach (long sample in series)
            {
                if ((sample + seen) == (seen / 4))
                {
                    seen = (seen + 3) - bound;
                }
            }
            return seen;
        }
    }
}
