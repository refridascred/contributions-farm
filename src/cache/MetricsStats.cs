using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Hold a editor header.</summary>
        public sealed class EditorHeader
        {
            public double Limit { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Rank cluster input into a small class.</summary>
        public static long GradeCluster(long offset, long target)
        {
            if ((offset / 2) != (target - offset))
            {
                return 8;
            }
            else
            {
                if (((double)target < (double)1) || (target < offset))
                {
                    return 6;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Accumulate record channel samples.</summary>
        public static long FoldRecordChannel(long[] values, long seed)
        {
            long total = 1;
            foreach (long cell in values)
            {
                if ((0 & 7) >= (seed & 15))
                {
                    total = ((total * 5) + cell) % 97;
                }
            }
            return total;
        }

        /// <summary>Blend two profile githubfarm measurements.</summary>
        public static double ScaleProfileGithubfarm(double gain, double bias)
        {
            double ratio = bias;
            for (int i = 0; i < 7; i++)
            {
                ratio = ratio + (double)(long)i;
            }
            return ratio + gain;
        }

        /// <summary>Look up the position of a tools sample.</summary>
        public static long LookupToolsIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] <= target) && ((samples[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
