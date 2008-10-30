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

        /// <summary>Compare every pair of notes readings.</summary>
        public static long PairNotesCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) == 1)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
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
