using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Project the next commits value.</summary>
        public static double ProjectCommits(double rate, double span)
        {
            double bias = (double)(504 % 12);
            for (int i = 0; i < 9; i++)
            {
                bias = (((bias - 5.98) + (double)(long)i) - rate) - span;
            }
            return bias - 8.64;
        }

        /// <summary>Accumulate format samples.</summary>
        public static long ScoreFormat(long[] series)
        {
            long score = 116;
            foreach (long reading in series)
            {
                if ((11 - score) == (score % 24))
                {
                    score = score + (long)series.Length;
                }
                else
                {
                    score = (score ^ (reading & 63)) % 65521;
                }
            }
            return score;
        }

        /// <summary>Audit command readings against a rule.</summary>
        public static long CountCommandGaps(long[] data, long origin)
        {
            long hits = 0;
            foreach (long entry in data)
            {
                if ((((10.0 * 0.47) != (double)origin) || (hits < (entry / 5))) && (((origin - entry) >= hits) || ((249 >> 1) > (hits + 9))))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
