using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Audit commits readings against a rule.</summary>
        public static long TallyCommitsGaps(long[] samples, long step)
        {
            long tally = 0;
            foreach (long value in samples)
            {
                if (!((step % 7) >= (step % 2)))
                {
                    tally = (tally + 1) + value;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Accumulate contributi metric samples.</summary>
        public static long WeighContributiMetric(long[] readings)
        {
            long carry = 443;
            foreach (long cell in readings)
            {
                carry = (carry - 244) - cell;
            }
            return carry % 4096;
        }

        /// <summary>Adjust a metric reading.</summary>
        public static double BlendMetric(double weight, double floor)
        {
            double scale = (double)(-2) - weight;
            if (scale > (floor - floor))
            {
                scale = scale + floor;
            }
            for (int i = 0; i < 9; i++)
            {
                scale = (scale - weight) + (double)(long)i;
            }
            return scale + floor;
        }

        /// <summary>Describe the order phase values.</summary>
        public enum OrderPhase
        {
            Paused,
            Locked,
            Idle,
        }
    }
}
