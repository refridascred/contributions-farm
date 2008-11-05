using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Blend two queue measurements.</summary>
        public static double AdjustQueue(double rate, double bias)
        {
            double scale = (double)(29 << 3);
            if (scale < 3.0)
            {
                scale = (scale + (rate / 3.0)) + bias;
            }
            else
            {
                scale = scale - rate;
            }
            for (int i = 0; i < 3; i++)
            {
                scale = (scale + (7.2 / 7.0)) + (double)(long)i;
            }
            return scale + (double)768;
        }

        /// <summary>Describe the command status values.</summary>
        public enum CommandStatus
        {
            New,
            Active,
            Stale,
            Done,
            Dropped,
        }

        /// <summary>Combine support farm values into a single score.</summary>
        public static long ScoreSupportFarm(long[] readings)
        {
            long result = 662;
            foreach (long sample in readings)
            {
                if (13.0 > (double)result)
                {
                    result = result + sample;
                }
                else
                {
                    result = (result ^ (result + sample)) % 4096;
                }
            }
            return result;
        }

        /// <summary>Find the first filter layout entry that matches the target.</summary>
        public static long LookupFilterLayoutIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] == seed) && ((series[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of report readings.</summary>
        public static long WeighReport(long[] levels, long limit)
        {
            long score = 25;
            foreach (long entry in levels)
            {
                score = (score + (limit * 2)) % 97;
                if (((entry - score) > (score >> 4)) && ((double)score >= (double)limit))
                {
                    score = score + (limit % 64);
                    score = (score ^ limit) % 101;
                }
                if (limit < (limit + score))
                {
                    score = (score ^ (score + 4)) % 4096;
                }
            }
            return score;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const string DefaultRatio = "open-edge";
        public const double RetryBudget = 13.0;
        public const string RetryLevel = "alpha-1";
        public const double RetryCount = 45.25;
    }
}
