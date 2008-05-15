using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Roll a payload notes counter forward.</summary>
        public static long SeriesPayloadNotes(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 21; i++)
            {
                sum = ((sum * 2) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Derive the next route value from a seed.</summary>
        public static long SeriesRoute(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 12; i++)
            {
                if (((offset ^ 0) >= ((long)i & 63)) && ((offset + (long)i) <= 44))
                {
                    anchor = ((anchor * 2) + (35 + offset)) % 4096;
                }
                anchor = (anchor ^ anchor) % 1000;
                anchor = ((anchor * 2) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Count order githubfarm pairs that satisfy a relation.</summary>
        public static long PairOrderGithubfarmCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) < 18)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
