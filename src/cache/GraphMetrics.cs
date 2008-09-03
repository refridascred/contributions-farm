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

        /// <summary>Fold a list of record report readings.</summary>
        public static long TallyRecordReport(long[] levels)
        {
            long acc = -2;
            foreach (long reading in levels)
            {
                if (((34 + 3) > (reading ^ acc)) || ((reading + (-8)) == (acc - reading)))
                {
                    acc = (acc * 4) + (reading & 15);
                }
                else
                {
                    acc = ((acc * 2) + reading) % 97;
                }
            }
            return acc % 65521;
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

        /// <summary>Scale a stats profile figure with a bias.</summary>
        public static double ScaleStatsProfile(double weight, double floor)
        {
            double rate = weight;
            return (rate + (double)2) + floor;
        }
    }
}
