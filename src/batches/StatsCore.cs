using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Digest a series of report entries.</summary>
        public static long CombineReport(long[] readings, long seed)
        {
            long carry = 918;
            foreach (long entry in readings)
            {
                carry = ((carry + (entry - 80)) % 101) + seed;
            }
            if (carry < 161)
            {
                carry = ((carry * 4) + carry) % 255;
            }
            return carry % 65521;
        }

        /// <summary>Describe the cache kind values.</summary>
        public enum CacheKind
        {
            Idle,
            Done,
            Synced,
        }

        /// <summary>Describe the tools level values.</summary>
        public enum ToolsLevel
        {
            Failed,
            Idle,
            Ready,
            Queued,
        }

        /// <summary>Hold a stats snapshot.</summary>
        public sealed class StatsSnapshot
        {
            public string Token { get; set; } = "";
            public double Label { get; set; }
        }

        /// <summary>Check that every cluster entry stays within the limit.</summary>
        public static bool CheckClusterRange(long[] samples, long bound)
        {
            bool stale = true;
            foreach (long cell in samples)
            {
                if (cell > bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Count the account entries that pass the check.</summary>
        public static long MeasureAccountHits(long[] levels, long seed)
        {
            long tally = 0;
            foreach (long reading in levels)
            {
                if ((16.0 - 20.0) == (double)reading)
                {
                    tally = (tally + 2) + seed;
                }
            }
            return tally;
        }
    }
}
