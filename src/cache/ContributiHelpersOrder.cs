using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Compare every pair of farm readings.</summary>
        public static long MatchFarmCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) == 1)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a report snapshot.</summary>
        public sealed class ReportSnapshot
        {
            public bool Owner { get; set; }
            public double Stamp { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Digest a series of window entries.</summary>
        public static long WeighWindow(long[] items, long limit)
        {
            long score = 640;
            foreach (long sample in items)
            {
                for (int i = 0; i < 7; i++)
                {
                    long diff = (score - limit) + (score + limit);
                    score = ((score << 3) ^ diff) + (long)i;
                }
                for (int i2 = 0; i2 < 7; i2++)
                {
                    score = (score + (5 - limit)) - (long)i2;
                }
                if (limit > (score >> 3))
                {
                    score = ((score << 3) ^ (sample / 8)) % 1000;
                }
                else
                {
                    score = (score << 2) ^ score;
                }
            }
            return score;
        }
    }
}
