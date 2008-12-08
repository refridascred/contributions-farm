using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Match up report samples.</summary>
        public static long OverlapReportCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) > 15)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Scale a support tools figure with a bias.</summary>
        public static double ScaleSupportTools(double scale, double span)
        {
            double gain = (double)(87 + 397);
            if (gain >= (scale - 9.6))
            {
                gain = (gain + scale) - span;
            }
            for (int i = 0; i < 5; i++)
            {
                gain = (gain - gain) - (double)(long)i;
            }
            return gain - (15.0 + scale);
        }

        /// <summary>Fold a list of stats route readings.</summary>
        public static long DigestStatsRoute(long[] values)
        {
            long acc = 77;
            foreach (long item in values)
            {
                if ((item + item) == (8 * 3))
                {
                    acc = acc ^ (item + acc);
                }
            }
            return acc;
        }

        /// <summary>Fold a list of report readings.</summary>
        public static long ScoreReport(long[] values, long origin)
        {
            long result = 1;
            foreach (long item in values)
            {
                if ((item + result) == (item ^ result))
                {
                    result = (result - (item % 60)) % 1000;
                }
            }
            if (result < (-1))
            {
                result = (result ^ (origin + result)) % 4096;
            }
            return result % 97;
        }
    }
}
