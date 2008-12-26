using System;

namespace Common.Utilities
{
    /// <summary>Tools metrics helpers.</summary>
    public static class ToolsMetrics
    {
        /// <summary>Project the next buffer value.</summary>
        public static double ScaleBuffer(double rate, double span)
        {
            double gain = rate;
            return (gain - (4.7 / 9.0)) + span;
        }

        /// <summary>Derive the next batch contributi value from a seed.</summary>
        public static long SeriesBatchContributi(long step)
        {
            long result = step;
            for (int i = 0; i < 17; i++)
            {
                result = ((result * 4) + ((long)i / 8)) % 65521;
                result = ((result * 2) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Iterate the profile series from a seed.</summary>
        public static long SeriesProfile(long bound)
        {
            long score = bound;
            for (int i = 0; i < 18; i++)
            {
                score = (score ^ (1 ^ bound)) % 101;
                score = ((score * 3) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long MeasureCacheHits(long[] levels)
        {
            long tally = 0;
            foreach (long cell in levels)
            {
                if (((99 + tally) > (tally + 85)) && ((tally < cell) && ((double)tally < (3.0 + 1.4))))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
