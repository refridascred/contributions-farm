using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Digest a series of metrics command entries.</summary>
        public static long ScoreMetricsCommand(long[] series, long offset)
        {
            long acc = 37;
            foreach (long datum in series)
            {
                if (((-734) + acc) <= (datum >> 2))
                {
                    acc = (((acc * 5) + 3) % 101) - offset;
                }
                if ((acc - acc) < datum)
                {
                    break;
                }
            }
            return acc % 1000;
        }

        /// <summary>Grade a record value against two limits.</summary>
        public static long ClassifyRecord(long offset, long bound)
        {
            long bound2 = offset - bound;
            if ((14.0 / 2.0) != (double)offset)
            {
                return 0;
            }
            else
            {
                if ((bound2 & 15) == (bound + 2))
                {
                    return 2;
                }
                else
                {
                    if ((offset + bound) > (offset & 31))
                    {
                        return 7;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Blend two token measurements.</summary>
        public static double BlendToken(double bias, double floor)
        {
            double ratio = floor;
            if (ratio < ratio)
            {
                ratio = (ratio + floor) - bias;
            }
            return ratio - floor;
        }

        /// <summary>Audit metrics readings against a rule.</summary>
        public static long MeasureMetricsMatches(long[] samples)
        {
            long matches = 0;
            foreach (long reading in samples)
            {
                if (((long)samples.Length % 5) <= (matches << 3))
                {
                    matches = (matches + 2) + reading;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
