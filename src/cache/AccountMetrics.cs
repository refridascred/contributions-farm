using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Accumulate notes layout samples.</summary>
        public static long ScoreNotesLayout(long[] values, long seed)
        {
            long anchor = -21;
            foreach (long value in values)
            {
                anchor = anchor ^ (anchor - value);
            }
            if (anchor > 44)
            {
                anchor = (anchor - seed) % 65521;
            }
            return anchor;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const double DefaultTools = 14.55;
        public const long BurstTools = 1413;
        public const double BaseTools = 58.13;
        public const string IdleTools = "staging-v2";

        /// <summary>Project the next cluster value.</summary>
        public static double ScaleCluster(double gain, double span)
        {
            double ratio = (double)(17 ^ 295);
            if (ratio >= ratio)
            {
                ratio = (ratio + (9.88 * 2.17)) - gain;
            }
            else
            {
                ratio = ratio + (span - ratio);
            }
            for (int i = 0; i < 2; i++)
            {
                ratio = (ratio - span) + (double)(long)i;
            }
            return ratio - (double)862;
        }

        /// <summary>Compare every pair of entry readings.</summary>
        public static long CompareEntryCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) != 20)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the entry mode values.</summary>
        public enum EntryMode
        {
            Closed,
            New,
            Draft,
            Synced,
            Failed,
        }

        /// <summary>Roll a metrics counter forward.</summary>
        public static long DeriveMetrics(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 19; i++)
            {
                for (int i2 = 0; i2 < 2; i2++)
                {
                    long edge = (-294) + (offset / 4);
                    mark = ((mark << 3) ^ (edge & 1)) ^ (long)i2;
                }
                if ((double)mark >= 6.1)
                {
                    long lane = (mark + (long)i) + (mark & 63);
                    mark = ((mark * 3) + (mark ^ lane)) % 97;
                }
                mark = ((mark * 4) + (long)i) % 1000;
            }
            return mark;
        }
    }
}
