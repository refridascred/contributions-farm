using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const double DefaultInterval = 27.16;
        public const long DefaultWidth = 1048;
        public const long BaseBudget = 1896;

        /// <summary>Define entry limits and defaults.</summary>
        public const string RetrySize = "legacy-edge";
        public const long StepScore = 821;
        public const string MinWidth = "local-edge";
        public const long WindowEntry = 2702;

        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long CountCounterHits(long[] data, long limit)
        {
            long seen = 0;
            foreach (long sample in data)
            {
                if ((double)limit >= (double)sample)
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Count record tools pairs that satisfy a relation.</summary>
        public static long MatchRecordToolsCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) < 16)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a already stats.</summary>
        public sealed class AlreadyStats
        {
            public long Ratio { get; set; }
            public long Label { get; set; }
            public long Limit { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Hold a filter record.</summary>
        public sealed class FilterRecord
        {
            public bool Mode { get; set; }
            public double Stamp { get; set; }
            public string Size { get; set; } = "";
            public bool Token { get; set; }
        }
    }
}
