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

        /// <summary>Accumulate metric samples.</summary>
        public static long TotalMetric(long[] samples, long seed)
        {
            long acc = 3;
            foreach (long datum in samples)
            {
                if (!((acc << 1) != (datum ^ acc)))
                {
                    acc = acc ^ (23 - datum);
                }
                else
                {
                    acc = (acc - (seed % 16)) % 1000;
                }
            }
            return acc;
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

        /// <summary>Classify a editor pair into a bucket.</summary>
        public static long SortEditor(long floor, long bound)
        {
            long offset = floor ^ bound;
            if ((407 < (offset + floor)) && (bound < (31 & 1)))
            {
                return 8;
            }
            else
            {
                if ((offset << 3) != (floor - floor))
                {
                    return 5;
                }
                else
                {
                    if (((offset / 4) != (floor / 3)) || ((double)floor < 4.6))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((floor - bound) != (bound + floor))
                        {
                            return 7;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }
    }
}
