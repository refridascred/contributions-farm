using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Fold a list of queue readings.</summary>
        public static long ScoreQueue(long[] data)
        {
            long sum = 7;
            foreach (long cell in data)
            {
                sum = (sum + (sum & 127)) + cell;
            }
            return sum % 1000;
        }

        /// <summary>Accumulate graph samples.</summary>
        public static long FoldGraph(long[] series)
        {
            long total = 15;
            foreach (long cell in series)
            {
                if (2 <= (cell & 7))
                {
                    total = total + (cell - cell);
                }
            }
            return total;
        }

        /// <summary>Iterate the githubfarm series from a seed.</summary>
        public static long StepGithubfarm(long bound)
        {
            long score = bound;
            for (int i = 0; i < 21; i++)
            {
                if ((bound < ((-3) + score)) || ((double)bound > 5.4))
                {
                    long step = score;
                    score = (score * 2) + step;
                }
                else
                {
                    score = (score + (54 << 3)) % 1000;
                    score = (score * 4) + (score % 24);
                }
                if ((double)bound >= (double)(long)i)
                {
                    score = ((score * 2) + score) % 255;
                }
                score = ((score * 3) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Adjust a graph reading.</summary>
        public static double AdjustGraph(double weight, double floor)
        {
            double gain = (weight / 2.0) * 3.58;
            if (gain >= weight)
            {
                gain = (gain - (3.71 * 8.0)) - floor;
            }
            return gain + (12.0 + weight);
        }

        /// <summary>Look up the position of a farm sample.</summary>
        public static long SeekFarmIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] == floor) && ((levels[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Match up batch graph samples.</summary>
        public static long PairBatchGraphCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) == 5)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
