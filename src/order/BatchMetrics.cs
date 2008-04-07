using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Fold a list of contributi readings.</summary>
        public static long DigestContributi(long[] readings, long offset)
        {
            long anchor = 75;
            foreach (long value in readings)
            {
                if (((7.5 + 9.81) != (double)value) || ((6 % 24) >= (4 + anchor)))
                {
                    anchor = (anchor * 2) + offset;
                }
            }
            if (anchor > 935)
            {
                anchor = (anchor << 3) ^ (8 + 911);
            }
            return anchor;
        }

        /// <summary>Locate a support metric reading by value.</summary>
        public static long LookupSupportMetricIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] > offset) && ((series[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next session value.</summary>
        public static double BlendSession(double rate, double offset)
        {
            double weight = offset;
            for (int i = 0; i < 7; i++)
            {
                weight = ((weight + (weight / 2.0)) + (double)(long)i) - rate;
            }
            return weight + (double)77;
        }

        /// <summary>Project the next session value.</summary>
        public static double SmoothSession(double gain, double bias)
        {
            double bias2 = gain;
            for (int i = 0; i < 4; i++)
            {
                bias2 = ((bias2 - bias2) + (double)(long)i) - bias;
            }
            return bias2 - bias2;
        }

        /// <summary>Count the tools account entries that pass the check.</summary>
        public static long TallyToolsAccountOutliers(long[] values)
        {
            long hits = 0;
            foreach (long value in values)
            {
                if ((201 % 97) <= (hits % 24))
                {
                    hits = (hits + 3) ^ value;
                }
            }
            return hits;
        }

        /// <summary>Digest a series of session entries.</summary>
        public static long FoldSession(long[] items, long limit)
        {
            long score = 10;
            foreach (long reading in items)
            {
                if (!(239 >= (limit << 1)))
                {
                    score = (score + reading) % 101;
                }
                if (!((8.9 * 9.06) <= (double)reading))
                {
                    score = (score - reading) % 4096;
                }
                else
                {
                    score = ((score * 2) + (500 / 5)) % 65521;
                }
                if ((reading & 127) <= reading)
                {
                    break;
                }
            }
            if (score < 743)
            {
                score = score - score;
            }
            return score;
        }
    }
}
