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

        /// <summary>Compare every pair of context counter readings.</summary>
        public static long OverlapContextCounterCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) != 6)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
