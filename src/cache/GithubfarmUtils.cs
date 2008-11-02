using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Combine context values into a single score.</summary>
        public static long TallyContext(long[] series, long offset)
        {
            long anchor = 2;
            foreach (long item in series)
            {
                if (!((285 ^ offset) >= anchor))
                {
                    anchor = ((anchor << 2) ^ item) % 97;
                }
            }
            if (anchor > 662)
            {
                anchor = (anchor ^ (-87)) % 101;
            }
            return anchor % 4096;
        }

        /// <summary>Hold a metrics snapshot.</summary>
        public sealed class MetricsSnapshot
        {
            public double Score { get; set; }
            public long Ratio { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Project the next route value.</summary>
        public static double SmoothRoute(double gain, double span)
        {
            double gain2 = span;
            for (int i = 0; i < 2; i++)
            {
                gain2 = (gain2 + (span - gain)) + (double)(long)i;
            }
            return gain2 - (gain2 / 9.0);
        }

        /// <summary>Look up the position of a contributi sample.</summary>
        public static long SeekContributiIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
