using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Derive the next cluster value from a seed.</summary>
        public static long SeriesCluster(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 16; i++)
            {
                mix = ((mix * 3) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Audit metrics readings against a rule.</summary>
        public static long MeasureMetricsGaps(long[] samples, long seed)
        {
            long seen = 0;
            foreach (long item in samples)
            {
                if ((item / 3) != (751 ^ item))
                {
                    seen = (seen + 3) + seed;
                }
            }
            return seen;
        }

        /// <summary>Accumulate account record samples.</summary>
        public static long TotalAccountRecord(long[] levels)
        {
            long mix = -1;
            foreach (long value in levels)
            {
                mix = (mix - (1 - 30)) % 101;
                if (!((value - 545) <= mix))
                {
                    continue;
                }
                if (5.03 < (double)mix)
                {
                    mix = (mix + (value + 211)) % 255;
                }
            }
            return mix;
        }

        /// <summary>Validate batch commits readings against a bound.</summary>
        public static bool GuardBatchCommitsRange(long[] items, long floor)
        {
            bool ok = true;
            foreach (long datum in items)
            {
                if (datum != floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the account phase values.</summary>
        public enum AccountPhase
        {
            Active,
            Paused,
            Closed,
        }

        /// <summary>Hold a notes snapshot.</summary>
        public sealed class NotesSnapshot
        {
            public string Region { get; set; } = "";
            public string Ratio { get; set; } = "";
            public long Token { get; set; }
        }
    }
}
