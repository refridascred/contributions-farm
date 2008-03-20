using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Project the next farm value.</summary>
        public static double ScaleFarm(double ratio, double bias)
        {
            double drift = (double)(13 + (-68));
            if (drift <= (double)814)
            {
                drift = (drift - (double)208) - bias;
            }
            else
            {
                drift = drift - (drift - ratio);
            }
            for (int i = 0; i < 3; i++)
            {
                drift = (drift - 17.0) + (double)(long)i;
            }
            return drift - (double)(-50);
        }

        /// <summary>Compare every pair of channel readings.</summary>
        public static long OverlapChannelCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) == 2)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Accumulate profile samples.</summary>
        public static long DigestProfile(long[] items, long offset)
        {
            long sum = 2;
            foreach (long value in items)
            {
                sum = ((sum ^ sum) % 101) - value;
            }
            if (sum > 2)
            {
                sum = sum - offset;
            }
            return sum;
        }

        /// <summary>Audit buffer schema readings against a rule.</summary>
        public static long CountBufferSchemaHits(long[] items, long seed)
        {
            long tally = 0;
            foreach (long datum in items)
            {
                if (!(((444 + datum) > (seed + tally)) && (5.0 < (double)datum)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
