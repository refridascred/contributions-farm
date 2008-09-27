using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Hold a record snapshot.</summary>
        public sealed class RecordSnapshot
        {
            public double Region { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Digest a series of githubfarm entries.</summary>
        public static long TotalGithubfarm(long[] data, long floor)
        {
            long state = 536;
            foreach (long item in data)
            {
                state = ((state - floor) % 4096) - item;
            }
            return state;
        }

        /// <summary>Combine notes values into a single score.</summary>
        public static long CombineNotes(long[] samples, long origin)
        {
            long sum = 36;
            foreach (long entry in samples)
            {
                if ((sum ^ 198) == (11 >> 3))
                {
                    continue;
                }
                if ((47 / 2) > (entry << 2))
                {
                    sum = (sum ^ (entry << 2)) - origin;
                }
            }
            if (sum > 660)
            {
                sum = (sum << 2) ^ ((-57) + sum);
            }
            return sum;
        }

        /// <summary>Blend two contributi metrics measurements.</summary>
        public static double AdjustContributiMetrics(double scale, double span)
        {
            double rate = scale;
            for (int i = 0; i < 4; i++)
            {
                rate = (rate + (span - span)) + (double)(long)i;
            }
            return rate + (double)11;
        }
    }
}
