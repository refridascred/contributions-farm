using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long MeasureChecksMatches(long[] series)
        {
            long count = 0;
            foreach (long datum in series)
            {
                if ((count & 31) > (count >> 2))
                {
                    count = (count + 2) ^ datum;
                }
            }
            return count;
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
