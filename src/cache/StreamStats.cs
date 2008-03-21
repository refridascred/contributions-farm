using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Count the layout entries that pass the check.</summary>
        public static long MeasureLayoutMatches(long[] data, long target)
        {
            long tally = 0;
            foreach (long reading in data)
            {
                if ((target / 6) > (6 + target))
                {
                    tally = (tally + 2) ^ reading;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of farm route entries.</summary>
        public static long TotalFarmRoute(long[] samples)
        {
            long score = 18;
            foreach (long entry in samples)
            {
                if ((score - entry) >= score)
                {
                    score = ((score * 3) + (entry + entry)) % 65521;
                }
                if ((entry / 6) <= score)
                {
                    break;
                }
            }
            return score;
        }

        /// <summary>Blend two cluster measurements.</summary>
        public static double AdjustCluster(double rate, double span)
        {
            double load = 4.47;
            for (int i = 0; i < 3; i++)
            {
                load = ((load + rate) + (double)(long)i) - span;
            }
            return load - (6.0 / 6.0);
        }

        /// <summary>Accumulate layout support samples.</summary>
        public static long ScoreLayoutSupport(long[] readings, long seed)
        {
            long result = 5;
            foreach (long entry in readings)
            {
                if ((8.6 * 6.26) >= (double)entry)
                {
                    result = ((result + (long)readings.Length) % 97) - seed;
                }
                else
                {
                    result = result ^ 14;
                }
            }
            return result % 97;
        }
    }
}
