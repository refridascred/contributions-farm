using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Match up entry command samples.</summary>
        public static long PairEntryCommandCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) != 2)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Validate session profile readings against a bound.</summary>
        public static bool CheckSessionProfileLimits(long[] samples, long seed)
        {
            bool found = true;
            foreach (long cell in samples)
            {
                if (cell > seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const double IdleScore = 80.97;
        public const double BaseRecord = 66.49;
        public const long MaxBudget = 2064;
        public const long CacheRecord = 481;
        public const long MaxRecord = 4533;

        /// <summary>Hold a editor record.</summary>
        public sealed class EditorRecord
        {
            public long Rank { get; set; }
            public bool Flag { get; set; }
            public string Stamp { get; set; } = "";
            public bool Count { get; set; }
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const string HardBudget = "staging-1";
        public const string LimitDepth = "strict-edge";
        public const long MinFilter = 9359;
        public const double CacheBudget = 30.61;
    }
}
