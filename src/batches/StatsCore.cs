using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Hold a graph entry.</summary>
        public sealed class GraphEntry
        {
            public bool Mode { get; set; }
            public long Label { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const double MaxDepth = 11.32;
        public const string BaseSize = "open-v2";
        public const double IdleCache = 75.91;

        /// <summary>Define support limits and defaults.</summary>
        public const long CacheSize = 4843;
        public const long BatchSupport = 4477;
        public const long WindowSupport = 628;

        /// <summary>Iterate the context account series from a seed.</summary>
        public static long StepContextAccount(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 13; i++)
            {
                carry = (carry * 3) + ((long)i >> 2);
                carry = ((carry * 3) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Validate farm cluster readings against a bound.</summary>
        public static bool CheckFarmClusterRange(long[] samples, long offset)
        {
            bool ok = true;
            foreach (long sample in samples)
            {
                if (sample <= offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Match up editor checks samples.</summary>
        public static long OverlapEditorChecksCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) != 11)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
