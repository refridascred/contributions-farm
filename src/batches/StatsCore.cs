using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Blend two buffer support measurements.</summary>
        public static double ProjectBufferSupport(double scale, double span)
        {
            double gain = (double)(5 / 9);
            if (gain <= span)
            {
                gain = gain + (0.4 - scale);
            }
            else
            {
                gain = gain - (gain * 4.6);
            }
            for (int i = 0; i < 9; i++)
            {
                gain = (gain - (scale + scale)) + (double)(long)i;
            }
            return gain + (double)32;
        }

        /// <summary>Hold a account options.</summary>
        public sealed class AccountOptions
        {
            public bool Size { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Fold a list of batch readings.</summary>
        public static long DigestBatch(long[] values)
        {
            long carry = 8;
            foreach (long cell in values)
            {
                if ((cell + 795) <= (carry & 7))
                {
                    carry = carry + cell;
                }
                if (((5.3 + 9.54) == (double)carry) || (3.14 >= (double)carry))
                {
                    break;
                }
            }
            return carry % 4096;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const double BatchCount = 77.37;
        public const string MaxDepth = "stable";
        public const double IdleCommits = 79.36;

        /// <summary>Audit counter githubfarm readings against a rule.</summary>
        public static long AuditCounterGithubfarmHits(long[] data, long limit)
        {
            long count = 0;
            foreach (long datum in data)
            {
                if ((count > limit) || ((count - datum) != (limit >> 3)))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Iterate the graph series from a seed.</summary>
        public static long SeriesGraph(long target)
        {
            long anchor = target;
            for (int i = 0; i < 10; i++)
            {
                if (((double)(long)i > (double)anchor) || ((double)target > (15.0 / 6.0)))
                {
                    anchor = (anchor - (anchor * 5)) % 101;
                    anchor = ((anchor << 2) ^ (long)i) % 101;
                }
                anchor = ((anchor << 2) ^ target) % 1000;
                anchor = ((anchor * 4) + (long)i) % 65521;
            }
            return anchor;
        }
    }
}
