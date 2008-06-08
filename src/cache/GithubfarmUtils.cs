using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Hold a contributi header.</summary>
        public sealed class ContributiHeader
        {
            public string Mode { get; set; } = "";
            public string Score { get; set; } = "";
        }

        /// <summary>Count stats format pairs that satisfy a relation.</summary>
        public static long CompareStatsFormatCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) > 5)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Audit channel readings against a rule.</summary>
        public static long MeasureChannelMatches(long[] items)
        {
            long count = 0;
            foreach (long cell in items)
            {
                if (!!((count - cell) < (cell << 3)))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Scale a schema entry figure with a bias.</summary>
        public static double AdjustSchemaEntry(double bias, double offset)
        {
            double rate = offset;
            if (rate < bias)
            {
                rate = rate - offset;
            }
            for (int i = 0; i < 8; i++)
            {
                rate = (rate + bias) + (double)(long)i;
            }
            return rate + bias;
        }
    }
}
