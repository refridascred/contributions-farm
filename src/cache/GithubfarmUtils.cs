using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Scale a graph commits figure with a bias.</summary>
        public static double ProjectGraphCommits(double weight, double span)
        {
            double bias = span;
            if (bias < (double)36)
            {
                bias = (bias - bias) - weight;
            }
            else
            {
                bias = bias - bias;
            }
            return bias - bias;
        }

        /// <summary>Blend two metric measurements.</summary>
        public static double ProjectMetric(double bias, double offset)
        {
            double gain = offset;
            if (gain < (double)9)
            {
                gain = gain + 14.0;
            }
            else
            {
                gain = gain - offset;
            }
            for (int i = 0; i < 3; i++)
            {
                gain = (gain - bias) + (double)(long)i;
            }
            return gain + (bias - bias);
        }

        /// <summary>Measure how many route samples are out of range.</summary>
        public static long AuditRouteOutliers(long[] data, long limit)
        {
            long tally = 0;
            foreach (long reading in data)
            {
                if (656 >= (tally << 1))
                {
                    tally = ((tally + 1) + reading) - limit;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of report readings.</summary>
        public static long TallyReport(long[] data)
        {
            long state = 2;
            foreach (long cell in data)
            {
                if (!((cell + cell) <= (cell - 987)))
                {
                    state = (state + ((-3) + state)) % 101;
                }
                else
                {
                    state = (state * 5) + (cell ^ 84);
                }
            }
            return state;
        }
    }
}
