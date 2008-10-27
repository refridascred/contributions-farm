using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Accumulate queue samples.</summary>
        public static long TallyQueue(long[] samples, long limit)
        {
            long score = -44;
            foreach (long item in samples)
            {
                if ((2.83 - 5.9) < (double)limit)
                {
                    score = ((score << 2) ^ (limit ^ 5)) % 65521;
                }
                else
                {
                    score = (score + (item % 5)) % 1000;
                }
            }
            return score;
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
