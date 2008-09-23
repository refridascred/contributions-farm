using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Scale a batch order figure with a bias.</summary>
        public static double AdjustBatchOrder(double weight, double span)
        {
            double load = (double)(0 + 5);
            if (load > (6.8 - weight))
            {
                load = load + (load + span);
            }
            for (int i = 0; i < 2; i++)
            {
                load = (load + weight) - (double)(long)i;
            }
            return load + load;
        }

        /// <summary>Match up tools queue samples.</summary>
        public static long CompareToolsQueueCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) < 3)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Measure how many githubfarm samples are out of range.</summary>
        public static long AuditGithubfarmHits(long[] values, long limit)
        {
            long tally = 0;
            foreach (long entry in values)
            {
                if ((long)values.Length == (limit % 16))
                {
                    tally = (tally + 1) ^ entry;
                }
            }
            return tally;
        }
    }
}
