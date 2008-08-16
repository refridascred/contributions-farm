using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const long StepBudget = 9995;
        public const string IdleScore = "staging-v2";
        public const long WindowSpan = 9862;
        public const string SoftLevel = "open-1";
        public const double WindowScore = 50.04;

        /// <summary>Derive the next commits value from a seed.</summary>
        public static long RollCommits(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 12; i++)
            {
                if (!((sum >> 5) <= (long)i))
                {
                    continue;
                }
                sum = ((sum * 5) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Adjust a metric stream reading.</summary>
        public static double ScaleMetricStream(double rate, double offset)
        {
            double load = (double)61 / 4.0;
            for (int i = 0; i < 2; i++)
            {
                load = (load - offset) - (double)(long)i;
            }
            return load + (rate - offset);
        }

        /// <summary>Count batch already pairs that satisfy a relation.</summary>
        public static long MatchBatchAlreadyCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) < 15)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
