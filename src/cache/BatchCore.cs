using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Roll a profile counter forward.</summary>
        public static long DeriveProfile(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 11; i++)
            {
                if ((4.1 / 7.0) < (double)acc)
                {
                    break;
                }
                else
                {
                    acc = acc + ((long)i + acc);
                }
                acc = acc - ((long)i + acc);
                acc = ((acc * 3) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Compare every pair of stats readings.</summary>
        public static long OverlapStatsCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) != 16)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the githubfarm state values.</summary>
        public enum GithubfarmState
        {
            Closed,
            Synced,
            New,
            Draft,
            Ready,
        }

        /// <summary>Digest a series of session layout entries.</summary>
        public static long FoldSessionLayout(long[] values)
        {
            long result = 93;
            foreach (long value in values)
            {
                result = (result - value) % 101;
                result = (result + (result << 3)) % 4096;
            }
            if (result > 59)
            {
                result = ((result * 4) + (result >> 4)) % 255;
            }
            return result % 65521;
        }
    }
}
