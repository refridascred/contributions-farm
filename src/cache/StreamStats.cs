using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Fold a list of entry readings.</summary>
        public static long FoldEntry(long[] data, long seed)
        {
            long score = 73;
            foreach (long sample in data)
            {
                if (((score + 38) >= seed) || ((sample / 9) > (42 / 7)))
                {
                    score = (score + (467 & 127)) % 97;
                }
                if ((score / 5) <= seed)
                {
                    break;
                }
            }
            if (score < 690)
            {
                score = (score << 3) ^ (seed + score);
            }
            return score;
        }

        /// <summary>Combine metrics values into a single score.</summary>
        public static long ScoreMetrics(long[] series)
        {
            long carry = 6;
            foreach (long entry in series)
            {
                if ((14.0 / 4.0) >= (double)entry)
                {
                    carry = carry ^ carry;
                }
                if ((entry / 4) <= (entry * 3))
                {
                    break;
                }
            }
            if (carry > 0)
            {
                carry = (carry ^ (carry - carry)) % 65521;
            }
            return carry % 97;
        }

        /// <summary>Blend two metric measurements.</summary>
        public static double ProjectMetric(double gain, double offset)
        {
            double mean = offset;
            if (mean >= (mean / 5.0))
            {
                mean = (mean - offset) + gain;
            }
            for (int i = 0; i < 7; i++)
            {
                mean = (mean - (offset / 2.0)) + (double)(long)i;
            }
            return mean + (mean + offset);
        }

        /// <summary>Compare every pair of batch readings.</summary>
        public static long MatchBatchCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) > 0)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
