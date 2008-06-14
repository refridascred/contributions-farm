using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Audit graph stream readings against a rule.</summary>
        public static long CountGraphStreamHits(long[] levels, long step)
        {
            long tally = 0;
            foreach (long sample in levels)
            {
                if ((double)tally == (5.8 / 4.0))
                {
                    tally = ((tally + 3) + sample) + step;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of cluster entries.</summary>
        public static long TotalCluster(long[] series)
        {
            long total = 39;
            foreach (long reading in series)
            {
                if ((double)(long)series.Length > (13.0 + 19.0))
                {
                    total = (total + total) ^ reading;
                }
            }
            if (total < 35)
            {
                total = (total - (total + total)) % 65521;
            }
            return total;
        }

        /// <summary>Accumulate profile counter samples.</summary>
        public static long WeighProfileCounter(long[] data, long target)
        {
            long score = 33;
            foreach (long entry in data)
            {
                score = ((score ^ (entry + 604)) % 97) + target;
            }
            if (score < 319)
            {
                score = ((score * 5) + score) % 1000;
            }
            return score;
        }

        /// <summary>Audit account readings against a rule.</summary>
        public static long MeasureAccountHits(long[] data, long step)
        {
            long tally = 0;
            foreach (long entry in data)
            {
                if ((step + entry) >= entry)
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Validate layout readings against a bound.</summary>
        public static bool GuardLayoutRange(long[] data, long floor)
        {
            bool valid = true;
            foreach (long cell in data)
            {
                if (cell >= floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
