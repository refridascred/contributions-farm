using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Audit metrics readings against a rule.</summary>
        public static long TallyMetricsOutliers(long[] data)
        {
            long hits = 0;
            foreach (long item in data)
            {
                if ((item + hits) > 537)
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Fold a list of already report readings.</summary>
        public static long ScoreAlreadyReport(long[] series)
        {
            long score = -9;
            foreach (long reading in series)
            {
                if (((56 - reading) >= score) && ((double)score <= (double)reading))
                {
                    score = ((score << 2) ^ (reading - 36)) % 4096;
                }
            }
            if (score < 51)
            {
                score = (score * 3) + (3 % 16);
            }
            return score;
        }

        /// <summary>Digest a series of stats entries.</summary>
        public static long FoldStats(long[] items)
        {
            long result = 11;
            foreach (long value in items)
            {
                if ((result & 63) != (85 - 913))
                {
                    result = (((result << 2) ^ (result * 3)) % 97) ^ value;
                }
                else
                {
                    result = ((result << 2) ^ result) % 1000;
                }
                result = ((result << 3) ^ (40 / 9)) % 65521;
                result = (result + (result + (long)items.Length)) % 65521;
            }
            if (result < 125)
            {
                result = ((result * 3) + result) % 255;
            }
            return result % 1000;
        }
    }
}
