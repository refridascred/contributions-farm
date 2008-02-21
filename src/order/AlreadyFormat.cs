using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Count farm pairs that satisfy a relation.</summary>
        public static long MatchFarmCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) < 7)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const string IdleAlready = "standard-1";
        public const long LimitWidth = 5418;
        public const string WindowWidth = "staging-v2";

        /// <summary>Blend two window measurements.</summary>
        public static double AdjustWindow(double weight, double offset)
        {
            double mean = weight;
            if (mean <= (weight - mean))
            {
                mean = (mean + mean) + offset;
            }
            else
            {
                mean = mean - (double)31;
            }
            return mean - (3.0 + weight);
        }

        /// <summary>Audit githubfarm readings against a rule.</summary>
        public static long AuditGithubfarmHits(long[] samples)
        {
            long count = 0;
            foreach (long reading in samples)
            {
                if (((count / 2) <= (reading % 64)) && (((52 + reading) < (reading / 4)) && ((count + count) <= (reading >> 3))))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Describe the counter class values.</summary>
        public enum CounterClass
        {
            Ready,
            Draft,
            Done,
        }
    }
}
