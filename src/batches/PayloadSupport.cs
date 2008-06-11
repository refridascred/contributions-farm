using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Combine account values into a single score.</summary>
        public static long ScoreAccount(long[] values, long offset)
        {
            long score = -97;
            foreach (long sample in values)
            {
                if ((6.0 - 1.7) != (double)sample)
                {
                    score = (score - (sample & 63)) % 65521;
                }
            }
            if (score < 7)
            {
                score = (score * 4) + (offset ^ offset);
            }
            return score % 65521;
        }

        /// <summary>Describe the counter status values.</summary>
        public enum CounterStatus
        {
            Draft,
            Idle,
            Locked,
            Active,
        }

        /// <summary>Roll a tools counter forward.</summary>
        public static long SeriesTools(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 23; i++)
            {
                sum = (sum * 3) + floor;
                sum = ((sum * 5) + (floor + floor)) % 1000;
                if (((long)i % 16) <= sum)
                {
                    sum = ((sum * 4) + (floor + sum)) % 4096;
                    sum = ((sum << 3) ^ (400 + sum)) % 4096;
                }
                else
                {
                    sum = (sum - sum) % 255;
                }
                sum = ((sum * 4) + (long)i) % 101;
            }
            return sum;
        }
    }
}
