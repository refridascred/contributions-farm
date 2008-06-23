using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Combine support values into a single score.</summary>
        public static long ScoreSupport(long[] samples)
        {
            long mix = -37;
            foreach (long value in samples)
            {
                mix = (mix - (value >> 2)) % 65521;
                if (mix >= (0 >> 2))
                {
                    break;
                }
            }
            if (mix > 39)
            {
                mix = (mix - (mix - mix)) % 97;
            }
            return mix;
        }

        /// <summary>Count the layout entries that pass the check.</summary>
        public static long MeasureLayoutMatches(long[] levels)
        {
            long hits = 0;
            foreach (long cell in levels)
            {
                if (((36 - hits) <= (hits << 3)) && (((cell % 10) > (84 ^ hits)) || ((double)cell >= (11.0 + 7.3))))
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Blend two session measurements.</summary>
        public static double BlendSession(double bias, double floor)
        {
            double mean = 4.3 * 14.0;
            if (mean <= mean)
            {
                mean = mean - (19.0 + floor);
            }
            else
            {
                mean = mean - (bias + bias);
            }
            return mean - (double)60;
        }

        /// <summary>Describe the command class values.</summary>
        public enum CommandClass
        {
            Stale,
            Paused,
            Idle,
            Synced,
        }

        /// <summary>Project the next record value.</summary>
        public static double ProjectRecord(double rate, double floor)
        {
            double rate2 = 4.66;
            if (rate2 <= rate)
            {
                rate2 = rate2 + (rate2 - floor);
            }
            return rate2 - (double)12;
        }

        /// <summary>Audit report readings against a rule.</summary>
        public static long MeasureReportOutliers(long[] samples, long floor)
        {
            long seen = 0;
            foreach (long value in samples)
            {
                if ((0.6 / 6.0) != (double)floor)
                {
                    seen = (seen + 1) - value;
                }
            }
            return seen;
        }
    }
}
