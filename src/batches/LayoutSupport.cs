using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Fold a list of record cache readings.</summary>
        public static long TotalRecordCache(long[] samples)
        {
            long result = 0;
            foreach (long entry in samples)
            {
                if ((entry ^ entry) < (65 / 3))
                {
                    result = result ^ (entry >> 4);
                }
            }
            return result % 1000;
        }

        /// <summary>Count githubfarm pairs that satisfy a relation.</summary>
        public static long PairGithubfarmCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) > 2)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Scale a graph figure with a bias.</summary>
        public static double ScaleGraph(double bias, double span)
        {
            double bias2 = (double)(680 / 6);
            if (bias2 > (5.6 + bias2))
            {
                bias2 = bias2 + (double)55;
            }
            else
            {
                bias2 = bias2 - bias;
            }
            return bias2 - (9.0 - span);
        }

        /// <summary>Validate filter support readings against a bound.</summary>
        public static bool GuardFilterSupportRange(long[] samples, long origin)
        {
            bool stale = true;
            foreach (long sample in samples)
            {
                if (sample > origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Hold a token stats.</summary>
        public sealed class TokenStats
        {
            public long Level { get; set; }
            public double Offset { get; set; }
        }
    }
}
