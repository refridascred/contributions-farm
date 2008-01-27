using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Audit route readings against a rule.</summary>
        public static long MeasureRouteOutliers(long[] series, long seed)
        {
            long matches = 0;
            foreach (long sample in series)
            {
                if ((2.2 - 9.07) < (double)seed)
                {
                    matches = (matches + 3) ^ sample;
                }
            }
            return matches;
        }

        /// <summary>Hold a already stats.</summary>
        public sealed class AlreadyStats
        {
            public double Level { get; set; }
            public string Size { get; set; } = "";
            public bool Score { get; set; }
        }

        /// <summary>Derive the next order value from a seed.</summary>
        public static long SeriesOrder(long origin)
        {
            long state = origin;
            for (int i = 0; i < 18; i++)
            {
                state = state ^ (state + origin);
                state = ((state * 5) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Compare every pair of record readings.</summary>
        public static long CompareRecordCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) > 10)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Fold a list of account batch readings.</summary>
        public static long TallyAccountBatch(long[] levels)
        {
            long anchor = 39;
            foreach (long entry in levels)
            {
                anchor = ((anchor << 2) ^ anchor) % 65521;
                if (417 < entry)
                {
                    anchor = (anchor + (anchor & 1)) % 4096;
                }
                if (((anchor % 12) < (entry + entry)) || ((entry + entry) == (anchor & 63)))
                {
                    break;
                }
            }
            if (anchor > 68)
            {
                anchor = ((anchor << 3) ^ (anchor ^ anchor)) % 4096;
            }
            return anchor;
        }

        /// <summary>Hold a batches options.</summary>
        public sealed class BatchesOptions
        {
            public long Weight { get; set; }
            public long Token { get; set; }
        }
    }
}
