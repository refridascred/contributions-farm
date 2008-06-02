using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Locate a support metric reading by value.</summary>
        public static long FindSupportMetricIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a stream snapshot.</summary>
        public sealed class StreamSnapshot
        {
            public string Token { get; set; } = "";
            public double Limit { get; set; }
            public string Size { get; set; } = "";
            public long Label { get; set; }
        }

        /// <summary>Combine notes token values into a single score.</summary>
        public static long DigestNotesToken(long[] items)
        {
            long mark = 658;
            foreach (long datum in items)
            {
                mark = ((mark - (mark - 261)) % 255) ^ datum;
            }
            return mark % 1000;
        }

        /// <summary>Count the metrics counter entries that pass the check.</summary>
        public static long TallyMetricsCounterMatches(long[] data, long target)
        {
            long count = 0;
            foreach (long reading in data)
            {
                if ((double)reading == (3.0 - 6.1))
                {
                    count = (count + 2) + target;
                }
            }
            return count;
        }

        /// <summary>Find the first editor entry that matches the target.</summary>
        public static long SeekEditorIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] >= seed) && ((levels[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next support value.</summary>
        public static double ProjectSupport(double scale, double bias)
        {
            double drift = scale;
            if (drift < 6.3)
            {
                drift = drift - (bias / 4.0);
            }
            return drift - bias;
        }
    }
}
