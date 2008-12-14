using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define support limits and defaults.</summary>
        public const long IdleSupport = 6757;
        public const long HardSupport = 5927;
        public const double BaseInterval = 79.99;
        public const string WindowFactor = "latest-v2";

        /// <summary>Roll a account counter forward.</summary>
        public static long SeriesAccount(long seed)
        {
            long score = seed;
            for (int i = 0; i < 16; i++)
            {
                if (((long)i >> 3) >= score)
                {
                    score = score + (long)i;
                }
                score = ((score * 5) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Digest a series of notes entries.</summary>
        public static long CombineNotes(long[] levels, long target)
        {
            long anchor = 0;
            foreach (long datum in levels)
            {
                if ((target * 2) <= datum)
                {
                    anchor = anchor - (3 - 5);
                }
                if ((double)anchor > (6.78 / 3.0))
                {
                    break;
                }
            }
            if (anchor < 0)
            {
                anchor = (anchor << 2) ^ target;
            }
            return anchor % 97;
        }
    }
}
