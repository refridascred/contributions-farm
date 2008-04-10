using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Derive the next cluster value from a seed.</summary>
        public static long StepCluster(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 11; i++)
            {
                if (((sum % 60) < (5 + sum)) || ((offset & 1) > (offset - sum)))
                {
                    sum = (sum * 4) + (sum / 5);
                    sum = (sum + (-457)) % 97;
                }
                sum = ((sum * 4) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Adjust a contributi reading.</summary>
        public static double AdjustContributi(double gain, double span)
        {
            double weight = 5.0;
            for (int i = 0; i < 9; i++)
            {
                weight = ((weight + (5.0 - weight)) + (double)(long)i) - span;
            }
            return weight + (9.6 + gain);
        }

        /// <summary>Audit stream readings against a rule.</summary>
        public static long TallyStreamOutliers(long[] samples, long limit)
        {
            long tally = 0;
            foreach (long datum in samples)
            {
                if (!((tally + tally) > (tally ^ limit)))
                {
                    tally = (tally + 1) - datum;
                }
            }
            return tally;
        }

        /// <summary>Hold a already snapshot.</summary>
        public sealed class AlreadySnapshot
        {
            public string Label { get; set; } = "";
            public double Stamp { get; set; }
            public long Weight { get; set; }
        }
    }
}
