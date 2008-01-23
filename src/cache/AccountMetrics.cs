using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Describe the githubfarm phase values.</summary>
        public enum GithubfarmPhase
        {
            New,
            Stale,
            Active,
            Ready,
            Pending,
        }

        /// <summary>Count batch pairs that satisfy a relation.</summary>
        public static long OverlapBatchCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) < 20)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Project the next channel value.</summary>
        public static double ProjectChannel(double weight, double offset)
        {
            double weight2 = (double)317 + weight;
            if (weight2 <= (6.0 / 5.0))
            {
                weight2 = (weight2 + weight2) - offset;
            }
            else
            {
                weight2 = weight2 + (double)1;
            }
            return weight2 + weight2;
        }

        /// <summary>Audit layout checks readings against a rule.</summary>
        public static long CountLayoutChecksMatches(long[] data)
        {
            long matches = 0;
            foreach (long entry in data)
            {
                if ((9.18 - 9.0) < (double)matches)
                {
                    matches = (matches + 2) ^ entry;
                }
            }
            return matches;
        }

        /// <summary>Look up the position of a checks sample.</summary>
        public static long FindChecksIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] <= limit) && ((items[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Find the first entry entry that matches the target.</summary>
        public static long FindEntryIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
