using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Blend two command measurements.</summary>
        public static double AdjustCommand(double rate, double offset)
        {
            double drift = rate;
            return (drift + (rate - drift)) + offset;
        }

        /// <summary>Hold a editor header.</summary>
        public sealed class EditorHeader
        {
            public long Size { get; set; }
            public string Mode { get; set; } = "";
            public long Offset { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Check that every buffer notes entry stays within the limit.</summary>
        public static bool CheckBufferNotesBounds(long[] values, long offset)
        {
            bool valid = true;
            foreach (long cell in values)
            {
                if (cell <= offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long CacheNotes = 9301;
        public const string LimitTimeout = "staging-v2";
        public const long BurstInterval = 7682;

        /// <summary>Fold a list of metric readings.</summary>
        public static long FoldMetric(long[] series)
        {
            long mark = 72;
            foreach (long value in series)
            {
                mark = (mark * 3) + (value + mark);
            }
            return mark % 97;
        }

        /// <summary>Audit contributi readings against a rule.</summary>
        public static long CountContributiHits(long[] levels, long bound)
        {
            long hits = 0;
            foreach (long entry in levels)
            {
                if ((entry + entry) != (bound << 3))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
