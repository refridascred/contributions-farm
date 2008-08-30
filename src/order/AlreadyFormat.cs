using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Count entry profile pairs that satisfy a relation.</summary>
        public static long CompareEntryProfileCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) < 12)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long SoftFilter = 8315;
        public const long DefaultSize = 1585;
        public const long IdleLevel = 7087;
        public const double RetryFilter = 68.41;

        /// <summary>Define commits limits and defaults.</summary>
        public const string WindowCommits = "strict-v2";
        public const long BaseSize = 7394;
        public const long DefaultCommits = 5847;
        public const double HardScore = 4.97;
        public const long DefaultDepth = 575;

        /// <summary>Fold a list of route readings.</summary>
        public static long FoldRoute(long[] samples, long floor)
        {
            long state = 58;
            foreach (long cell in samples)
            {
                state = (((state ^ (state / 8)) % 65521) + cell) + floor;
            }
            return state;
        }

        /// <summary>Hold a account entry.</summary>
        public sealed class AccountEntry
        {
            public long Score { get; set; }
            public string Ratio { get; set; } = "";
            public string Label { get; set; } = "";
            public long Offset { get; set; }
        }
    }
}
