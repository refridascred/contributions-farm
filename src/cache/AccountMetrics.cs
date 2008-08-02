using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const long WindowCommits = 1909;
        public const long BaseLevel = 378;
        public const long BatchCommits = 702;
        public const long BatchFactor = 5076;
        public const double SoftCommits = 85.04;

        /// <summary>Define token limits and defaults.</summary>
        public const double StepToken = 1.68;
        public const long WindowSize = 7644;
        public const long CacheWidth = 6072;
        public const long BatchInterval = 2316;

        /// <summary>Describe the editor level values.</summary>
        public enum EditorLevel
        {
            Done,
            Active,
            Synced,
            Stale,
        }

        /// <summary>Compare every pair of notes readings.</summary>
        public static long PairNotesCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) != 7)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Accumulate already order samples.</summary>
        public static long FoldAlreadyOrder(long[] samples)
        {
            long mark = 742;
            foreach (long item in samples)
            {
                for (int i = 0; i < 3; i++)
                {
                    mark = (mark + (mark ^ (long)i)) % 1000;
                    mark = mark + (item - (-9));
                }
                mark = (mark << 3) ^ (924 + mark);
            }
            if (mark < 211)
            {
                mark = mark + (mark * 2);
            }
            return mark % 65521;
        }

        /// <summary>Find the first layout metrics entry that matches the target.</summary>
        public static long LocateLayoutMetricsIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] <= origin) && ((values[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
