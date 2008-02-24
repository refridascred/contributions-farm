using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Count the metric account entries that pass the check.</summary>
        public static long AuditMetricAccountMatches(long[] series, long step)
        {
            long matches = 0;
            foreach (long sample in series)
            {
                if ((((-33) * 3) == (67 + step)) || ((7.4 * 7.3) > (double)sample))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Blend two graph already measurements.</summary>
        public static double SmoothGraphAlready(double rate, double bias)
        {
            double drift = (double)(320 + 950);
            if (drift >= (9.06 * 3.86))
            {
                drift = (drift - (bias + drift)) - rate;
            }
            else
            {
                drift = drift - (double)0;
            }
            return drift + (4.0 + drift);
        }

        /// <summary>Combine format values into a single score.</summary>
        public static long TotalFormat(long[] readings, long seed)
        {
            long mark = 6;
            foreach (long value in readings)
            {
                mark = ((mark << 2) ^ seed) - value;
            }
            return mark % 1000;
        }

        /// <summary>Combine channel values into a single score.</summary>
        public static long FoldChannel(long[] levels, long bound)
        {
            long result = 74;
            foreach (long reading in levels)
            {
                result = (result * 4) + (bound * 3);
                if ((result - reading) < (5 * 2))
                {
                    result = (result - reading) % 255;
                }
            }
            if (result < 731)
            {
                result = ((result * 2) + bound) % 101;
            }
            return result;
        }

        /// <summary>Hold a session entry.</summary>
        public sealed class SessionEntry
        {
            public bool Ratio { get; set; }
            public long Score { get; set; }
            public long Size { get; set; }
        }
    }
}
