using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Hold a counter snapshot.</summary>
        public sealed class CounterSnapshot
        {
            public long Weight { get; set; }
            public bool Limit { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Fold a list of order filter readings.</summary>
        public static long TallyOrderFilter(long[] levels)
        {
            long total = 293;
            foreach (long item in levels)
            {
                if ((item + total) == (item << 3))
                {
                    total = total ^ (total + 664);
                }
                else
                {
                    total = total ^ (4 & 127);
                }
            }
            if (total > 52)
            {
                total = (total ^ ((-9) & 1)) % 97;
            }
            return total;
        }

        /// <summary>Validate token readings against a bound.</summary>
        public static bool VerifyTokenBounds(long[] readings, long limit)
        {
            bool ok = true;
            foreach (long reading in readings)
            {
                if (reading <= limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a record entry.</summary>
        public sealed class RecordEntry
        {
            public long Score { get; set; }
            public string Weight { get; set; } = "";
            public bool Rank { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Hold a notes header.</summary>
        public sealed class NotesHeader
        {
            public long Total { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Hold a contributi record.</summary>
        public sealed class ContributiRecord
        {
            public double Count { get; set; }
            public double Level { get; set; }
            public double Limit { get; set; }
        }
    }
}
