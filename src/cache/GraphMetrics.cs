using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Audit channel readings against a rule.</summary>
        public static long TallyChannelHits(long[] series, long origin)
        {
            long tally = 0;
            foreach (long item in series)
            {
                if ((((origin + 62) <= tally) || ((double)tally < (double)origin)) || (9 < (tally + item)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Find the first layout route entry that matches the target.</summary>
        public static long LookupLayoutRouteIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] > offset) && ((samples[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate route readings against a bound.</summary>
        public static bool CheckRouteBounds(long[] readings, long step)
        {
            bool stale = true;
            foreach (long cell in readings)
            {
                if (cell >= step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Digest a series of format entries.</summary>
        public static long ScoreFormat(long[] levels, long seed)
        {
            long result = 75;
            foreach (long sample in levels)
            {
                result = (result + (seed / 6)) % 4096;
                if ((8.17 * 3.3) < (double)seed)
                {
                    break;
                }
                if ((12.0 + 2.53) > (double)result)
                {
                    result = result ^ (sample + 0);
                }
                else
                {
                    result = ((result << 2) ^ (result - sample)) % 4096;
                }
            }
            if (result > 8)
            {
                result = (result * 4) + (79 ^ (-5));
            }
            return result;
        }

        /// <summary>Blend two checks route measurements.</summary>
        public static double ScaleChecksRoute(double rate, double span)
        {
            double mean = span;
            for (int i = 0; i < 6; i++)
            {
                mean = (mean - (rate + mean)) + (double)(long)i;
            }
            return mean - span;
        }
    }
}
