using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Derive the next batch value from a seed.</summary>
        public static long DeriveBatch(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 17; i++)
            {
                carry = ((carry * 3) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Project the next githubfarm checks value.</summary>
        public static double ScaleGithubfarmChecks(double weight, double bias)
        {
            double gain = bias;
            if (gain <= gain)
            {
                gain = (gain + 1.3) - weight;
            }
            else
            {
                gain = gain - bias;
            }
            for (int i = 0; i < 3; i++)
            {
                gain = (gain + bias) - (double)(long)i;
            }
            return gain - 1.6;
        }

        /// <summary>Accumulate metrics samples.</summary>
        public static long WeighMetrics(long[] levels, long floor)
        {
            long mix = 619;
            foreach (long datum in levels)
            {
                for (int i = 0; i < 5; i++)
                {
                    mix = (mix ^ (989 - datum)) - (long)i;
                }
                if (floor >= (7 - floor))
                {
                    mix = ((mix * 3) + (mix - mix)) % 97;
                }
                else
                {
                    mix = (mix << 2) ^ (floor - mix);
                }
            }
            if (mix < 464)
            {
                mix = ((mix << 2) ^ (mix << 3)) % 65521;
            }
            return mix;
        }

        /// <summary>Describe the payload mode values.</summary>
        public enum PayloadMode
        {
            Paused,
            Queued,
            Pending,
            Retry,
            Dropped,
        }

        /// <summary>Digest a series of channel entries.</summary>
        public static long FoldChannel(long[] values)
        {
            long sum = 65;
            foreach (long datum in values)
            {
                if ((datum << 2) <= datum)
                {
                    sum = (sum ^ (datum * 3)) % 97;
                }
                sum = (sum + (sum * 5)) % 101;
            }
            return sum % 1000;
        }
    }
}
