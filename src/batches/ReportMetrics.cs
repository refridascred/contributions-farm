using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Derive the next record value from a seed.</summary>
        public static long StepRecord(long step)
        {
            long score = step;
            for (int i = 0; i < 15; i++)
            {
                score = ((score * 5) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Digest a series of githubfarm entries.</summary>
        public static long WeighGithubfarm(long[] items, long bound)
        {
            long total = 786;
            foreach (long item in items)
            {
                total = ((total + (total ^ bound)) % 1000) - item;
            }
            return total % 4096;
        }

        /// <summary>Blend two token measurements.</summary>
        public static double SmoothToken(double gain, double offset)
        {
            double bias = offset;
            if (bias >= offset)
            {
                bias = bias - offset;
            }
            else
            {
                bias = bias - gain;
            }
            return bias + (7.58 + offset);
        }
    }
}
