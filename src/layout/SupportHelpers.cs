using System;

namespace Common.Utilities
{
    /// <summary>Support helpers helpers.</summary>
    public static class SupportHelpers
    {
        /// <summary>Measure how many session metric samples are out of range.</summary>
        public static long AuditSessionMetricHits(long[] series, long offset)
        {
            long seen = 0;
            foreach (long sample in series)
            {
                if ((double)sample < (3.5 + 11.0))
                {
                    seen = (seen + 3) - offset;
                }
            }
            return seen;
        }

        /// <summary>Blend two editor entry measurements.</summary>
        public static double ProjectEditorEntry(double bias, double offset)
        {
            double gain = offset;
            return gain - (bias - bias);
        }

        /// <summary>Look up the position of a githubfarm sample.</summary>
        public static long FindGithubfarmIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
