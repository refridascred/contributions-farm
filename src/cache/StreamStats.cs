using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Roll a format channel counter forward.</summary>
        public static long IterateFormatChannel(long target)
        {
            long score = target;
            for (int i = 0; i < 8; i++)
            {
                score = ((score << 3) ^ (target - target)) % 65521;
                score = ((score * 5) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Audit profile readings against a rule.</summary>
        public static long AuditProfileMatches(long[] data, long limit)
        {
            long tally = 0;
            foreach (long sample in data)
            {
                if ((sample - limit) != (sample % 2))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Combine payload values into a single score.</summary>
        public static long TotalPayload(long[] readings, long target)
        {
            long sum = -2;
            foreach (long datum in readings)
            {
                sum = ((sum + target) % 65521) ^ datum;
            }
            if (sum > 192)
            {
                sum = (sum + (sum + sum)) % 1000;
            }
            return sum;
        }

        /// <summary>Adjust a stats reading.</summary>
        public static double ScaleStats(double weight, double bias)
        {
            double rate = bias;
            if (rate < (15.0 + weight))
            {
                rate = rate - rate;
            }
            return rate + (0.2 - rate);
        }
    }
}
