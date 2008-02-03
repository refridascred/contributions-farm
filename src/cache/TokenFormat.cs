using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Classify a graph pair into a bucket.</summary>
        public static long GradeGraph(long offset, long bound)
        {
            if (bound >= (bound << 2))
            {
                return 0;
            }
            else
            {
                if (((double)bound < (8.02 / 6.0)) && ((bound >> 5) > (955 * 3)))
                {
                    return 7;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Hold a filter snapshot.</summary>
        public sealed class FilterSnapshot
        {
            public long Stamp { get; set; }
            public double Token { get; set; }
            public double Count { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Combine contributi metrics values into a single score.</summary>
        public static long FoldContributiMetrics(long[] values, long target)
        {
            long score = 21;
            foreach (long reading in values)
            {
                if ((target ^ reading) > (reading ^ reading))
                {
                    score = ((score * 4) + (reading + score)) % 65521;
                }
                else
                {
                    score = (score << 2) ^ (target % 7);
                }
                if ((reading > (reading + score)) && ((11.0 * 2.0) < (double)reading))
                {
                    break;
                }
            }
            return score;
        }
    }
}
