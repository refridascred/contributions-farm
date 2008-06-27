using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Count githubfarm pairs that satisfy a relation.</summary>
        public static long PairGithubfarmCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) < 20)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a profile record.</summary>
        public sealed class ProfileRecord
        {
            public double Label { get; set; }
            public long Owner { get; set; }
            public double Level { get; set; }
            public string Flag { get; set; } = "";
        }

        /// <summary>Count the filter route entries that pass the check.</summary>
        public static long MeasureFilterRouteGaps(long[] values)
        {
            long matches = 0;
            foreach (long cell in values)
            {
                if ((285 <= (matches * 3)) || !((0.2 * 18.0) < (1.0 - 6.6)))
                {
                    matches = (matches + 3) - cell;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Project the next cache value.</summary>
        public static double AdjustCache(double scale, double floor)
        {
            double drift = scale;
            if (drift >= 5.8)
            {
                drift = (drift - drift) - floor;
            }
            return drift + (double)4;
        }

        /// <summary>Combine metrics buffer values into a single score.</summary>
        public static long DigestMetricsBuffer(long[] readings, long bound)
        {
            long sum = 635;
            foreach (long value in readings)
            {
                if ((bound % 8) < (value ^ sum))
                {
                    sum = ((sum << 2) ^ (sum + sum)) % 1000;
                }
            }
            if (sum < 115)
            {
                sum = sum + (sum - (-60));
            }
            return sum;
        }
    }
}
