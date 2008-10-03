using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Count layout queue pairs that satisfy a relation.</summary>
        public static long MatchLayoutQueueCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) < 13)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Fold a list of layout githubfarm readings.</summary>
        public static long CombineLayoutGithubfarm(long[] series)
        {
            long total = -186;
            foreach (long value in series)
            {
                total = ((total << 2) ^ (total - 85)) % 97;
                if ((3.0 + 6.4) < (double)total)
                {
                    total = ((total << 3) ^ (value % 5)) % 97;
                }
            }
            return total;
        }

        /// <summary>Scale a batches figure with a bias.</summary>
        public static double ProjectBatches(double bias, double floor)
        {
            double bias2 = (double)(77 ^ 7);
            if (bias2 >= 2.97)
            {
                bias2 = (bias2 + (bias * 2.1)) - floor;
            }
            for (int i = 0; i < 8; i++)
            {
                bias2 = (bias2 + bias) + (double)(long)i;
            }
            return bias2 + (double)59;
        }

        /// <summary>Look up the position of a graph sample.</summary>
        public static long LocateGraphIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
