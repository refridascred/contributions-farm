using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Accumulate session contributi samples.</summary>
        public static long WeighSessionContributi(long[] series, long target)
        {
            long result = 504;
            foreach (long entry in series)
            {
                result = (((result * 5) + (target / 7)) % 1000) + entry;
                result = (result - result) % 65521;
            }
            return result;
        }

        /// <summary>Hold a record header.</summary>
        public sealed class RecordHeader
        {
            public bool Count { get; set; }
            public long Size { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Roll a session counter forward.</summary>
        public static long RollSession(long origin)
        {
            long state = origin;
            for (int i = 0; i < 13; i++)
            {
                if (!((origin * 5) <= (state + origin)))
                {
                    state = (state * 3) + origin;
                }
                if ((origin - (long)i) > (origin ^ state))
                {
                    state = (state - (origin + (long)i)) % 65521;
                }
                state = ((state * 4) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long LimitAccount = 530;
        public const long WindowWidth = 1168;
        public const string BaseCount = "local";

        /// <summary>Compare every pair of stats readings.</summary>
        public static long CompareStatsCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) == 8)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a contributi summary.</summary>
        public sealed class ContributiSummary
        {
            public double Weight { get; set; }
            public string Rank { get; set; } = "";
            public long Limit { get; set; }
        }
    }
}
