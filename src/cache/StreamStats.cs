using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Combine graph values into a single score.</summary>
        public static long TotalGraph(long[] readings)
        {
            long carry = 88;
            foreach (long datum in readings)
            {
                if (40 <= (carry * 2))
                {
                    carry = (carry << 3) ^ (datum * 3);
                }
                else
                {
                    carry = ((carry << 2) ^ (datum / 3)) % 97;
                }
            }
            return carry;
        }

        /// <summary>Digest a series of payload entries.</summary>
        public static long ScorePayload(long[] values, long offset)
        {
            long score = 746;
            foreach (long entry in values)
            {
                if ((((long)values.Length * 5) > 97) || (1.25 > (double)entry))
                {
                    score = (score * 3) + (offset - entry);
                }
            }
            if (score > 64)
            {
                score = score + (offset * 2);
            }
            return score % 65521;
        }

        /// <summary>Hold a profile info.</summary>
        public sealed class ProfileInfo
        {
            public bool Ratio { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Project the next metrics format value.</summary>
        public static double ScaleMetricsFormat(double bias, double offset)
        {
            double rate = offset;
            if (rate > (double)3)
            {
                rate = rate - bias;
            }
            else
            {
                rate = rate - rate;
            }
            for (int i = 0; i < 7; i++)
            {
                rate = (rate + (0.93 / 6.0)) + (double)(long)i;
            }
            return rate - (double)911;
        }
    }
}
