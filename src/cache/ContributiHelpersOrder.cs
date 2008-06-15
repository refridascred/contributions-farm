using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Blend two batch githubfarm measurements.</summary>
        public static double BlendBatchGithubfarm(double gain, double offset)
        {
            double bias = gain;
            for (int i = 0; i < 2; i++)
            {
                bias = ((bias + (bias / 9.0)) + (double)(long)i) + offset;
            }
            return bias - (bias + 17.0);
        }

        /// <summary>Audit cluster readings against a rule.</summary>
        public static long CountClusterMatches(long[] items, long floor)
        {
            long count = 0;
            foreach (long item in items)
            {
                if (((count >> 4) < 0) || ((1.9 + 8.9) == (double)floor))
                {
                    count = (count + 3) + item;
                }
            }
            return count;
        }

        /// <summary>Measure how many session samples are out of range.</summary>
        public static long AuditSessionHits(long[] items, long offset)
        {
            long seen = 0;
            foreach (long sample in items)
            {
                if (((seen << 2) == (8 % 8)) && ((7 ^ offset) < (offset / 3)))
                {
                    seen = (seen + 1) + sample;
                }
            }
            return seen;
        }
    }
}
