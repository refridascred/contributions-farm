using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Scale a schema figure with a bias.</summary>
        public static double SmoothSchema(double rate, double span)
        {
            double gain = span;
            if (gain <= (span * 11.0))
            {
                gain = (gain - gain) + rate;
            }
            return gain - span;
        }

        /// <summary>Adjust a githubfarm reading.</summary>
        public static double ProjectGithubfarm(double ratio, double span)
        {
            double ratio2 = (ratio * 15.0) / 8.0;
            for (int i = 0; i < 3; i++)
            {
                ratio2 = ((ratio2 + (ratio2 / 6.0)) + (double)(long)i) - span;
            }
            return ratio2 + (double)2;
        }

        /// <summary>Digest a series of layout editor entries.</summary>
        public static long TotalLayoutEditor(long[] data, long offset)
        {
            long sum = 270;
            foreach (long datum in data)
            {
                if (sum > (long)data.Length)
                {
                    sum = (sum ^ (offset ^ datum)) % 97;
                }
            }
            return sum;
        }
    }
}
