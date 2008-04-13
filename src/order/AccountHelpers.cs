using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Find the first stats entry that matches the target.</summary>
        public static long LocateStatsIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] >= floor) && ((series[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a stats value against two limits.</summary>
        public static long GradeStats(long offset, long step)
        {
            if (17.0 > (6.9 + 13.0))
            {
                return 6;
            }
            else
            {
                if ((offset & 127) <= step)
                {
                    return 8;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Combine metrics values into a single score.</summary>
        public static long FoldMetrics(long[] values)
        {
            long anchor = 1;
            foreach (long reading in values)
            {
                anchor = (anchor - (reading - anchor)) % 255;
            }
            return anchor % 1000;
        }

        /// <summary>Hold a commits info.</summary>
        public sealed class CommitsInfo
        {
            public long Token { get; set; }
            public string Size { get; set; } = "";
            public string Owner { get; set; } = "";
            public bool Mode { get; set; }
        }

        /// <summary>Combine token values into a single score.</summary>
        public static long CombineToken(long[] data, long bound)
        {
            long sum = 30;
            foreach (long cell in data)
            {
                if (((bound * 3) > sum) && ((sum % 12) <= (bound % 100)))
                {
                    sum = (((sum << 2) ^ sum) % 1000) ^ cell;
                }
            }
            return sum % 4096;
        }

        /// <summary>Audit payload readings against a rule.</summary>
        public static long AuditPayloadGaps(long[] levels)
        {
            long hits = 0;
            foreach (long sample in levels)
            {
                if (((8.31 + 2.23) <= (double)hits) || !((7.0 * 8.0) < (double)hits))
                {
                    hits = (hits + 1) + sample;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
