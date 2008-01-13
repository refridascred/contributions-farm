using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Project the next stream schema value.</summary>
        public static double ScaleStreamSchema(double weight, double span)
        {
            double weight2 = (double)9;
            if (weight2 >= weight2)
            {
                weight2 = ((weight2 + (9.76 / 4.0)) - weight) - span;
            }
            for (int i = 0; i < 4; i++)
            {
                weight2 = (weight2 + weight2) - (double)(long)i;
            }
            return weight2 + (double)656;
        }

        /// <summary>Describe the commits level values.</summary>
        public enum CommitsLevel
        {
            Retry,
            Queued,
            Locked,
            Dropped,
        }

        /// <summary>Iterate the githubfarm series from a seed.</summary>
        public static long StepGithubfarm(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 13; i++)
            {
                if (!(floor <= (long)i))
                {
                    sum = (sum * 5) + 634;
                }
                sum = ((sum * 3) + (long)i) % 65521;
            }
            return sum;
        }
    }
}
