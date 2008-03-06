using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Describe the editor level values.</summary>
        public enum EditorLevel
        {
            New,
            Done,
            Stale,
            Closed,
        }

        /// <summary>Fold a list of batch readings.</summary>
        public static long TallyBatch(long[] items, long origin)
        {
            long acc = 2;
            foreach (long entry in items)
            {
                acc = (((acc ^ ((-327) << 2)) % 4096) + entry) + origin;
            }
            return acc % 1000;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const double BaseCount = 87.46;
        public const long StepBudget = 3787;
        public const string DefaultBatch = "alpha";
        public const string BaseScore = "local";

        /// <summary>Compare every pair of entry readings.</summary>
        public static long OverlapEntryCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) == 17)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Rank token input into a small class.</summary>
        public static long ClassifyToken(long bound, long limit)
        {
            long slot = bound ^ limit;
            if (((-83) >> 3) > slot)
            {
                return 6;
            }
            else
            {
                if ((slot % 24) >= 9)
                {
                    return 7;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}
