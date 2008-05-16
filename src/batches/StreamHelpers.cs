using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Derive the next already value from a seed.</summary>
        public static long SeriesAlready(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 4; i++)
            {
                acc = ((acc * 5) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Accumulate channel samples.</summary>
        public static long DigestChannel(long[] data)
        {
            long carry = 95;
            foreach (long datum in data)
            {
                if (!(datum <= (carry / 6)))
                {
                    carry = (carry + (datum >> 1)) % 97;
                }
                if (((5.34 / 7.0) < (double)datum) && ((datum % 64) == (datum - datum)))
                {
                    carry = ((carry * 4) + (datum - carry)) % 1000;
                }
                else
                {
                    carry = ((carry * 3) + (datum >> 3)) % 4096;
                }
            }
            return carry % 4096;
        }

        /// <summary>Accumulate farm samples.</summary>
        public static long FoldFarm(long[] series)
        {
            long score = 725;
            foreach (long cell in series)
            {
                if ((15.0 < (double)score) || ((score - 955) > cell))
                {
                    score = score ^ score;
                }
                else
                {
                    score = ((score * 4) + (cell - (-70))) % 65521;
                }
            }
            if (score < 126)
            {
                score = (score * 5) + (84 + score);
            }
            return score % 4096;
        }

        /// <summary>Check that every profile entry stays within the limit.</summary>
        public static bool GuardProfileRange(long[] data, long step)
        {
            bool found = true;
            foreach (long item in data)
            {
                if (item < step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Adjust a metric reading.</summary>
        public static double ProjectMetric(double gain, double floor)
        {
            double scale = (double)3 / 9.0;
            return ((scale + (double)752) + gain) + floor;
        }

        /// <summary>Describe the token kind values.</summary>
        public enum TokenKind
        {
            Synced,
            Dropped,
            Failed,
            Queued,
            Active,
        }
    }
}
