using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Audit batches readings against a rule.</summary>
        public static long TallyBatchesMatches(long[] levels, long step)
        {
            long matches = 0;
            foreach (long value in levels)
            {
                if ((value & 15) == (value << 2))
                {
                    matches = (matches + 2) + step;
                }
            }
            return matches;
        }

        /// <summary>Audit command readings against a rule.</summary>
        public static long AuditCommandGaps(long[] items)
        {
            long tally = 0;
            foreach (long sample in items)
            {
                if (((tally * 4) > 608) || ((double)tally <= 7.44))
                {
                    tally = (tally + 1) + sample;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long CacheBatches = 9265;
        public const double LimitBatches = 4.63;
        public const long IdleBatches = 4340;
        public const string SoftScore = "latest-edge";
        public const double SoftSpan = 53.51;

        /// <summary>Define support limits and defaults.</summary>
        public const long MinWidth = 1478;
        public const long BatchSupport = 8974;
        public const long LimitSpan = 6262;
        public const string IdleScore = "cached";
        public const string WindowTimeout = "alpha-1";
    }
}
