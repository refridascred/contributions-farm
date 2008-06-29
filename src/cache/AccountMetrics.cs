using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Audit session readings against a rule.</summary>
        public static long MeasureSessionGaps(long[] readings, long offset)
        {
            long matches = 0;
            foreach (long value in readings)
            {
                if (!((matches & 1) > (2 + matches)))
                {
                    matches = ((matches + 2) + value) - offset;
                }
            }
            return matches;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long MinSize = 4572;
        public const long IdleWindow = 7780;
        public const long BatchWindow = 1991;
        public const long BurstDepth = 4219;

        /// <summary>Hold a entry header.</summary>
        public sealed class EntryHeader
        {
            public long Limit { get; set; }
            public double Token { get; set; }
            public bool Weight { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Hold a cache summary.</summary>
        public sealed class CacheSummary
        {
            public double Flag { get; set; }
            public bool Token { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Match up notes samples.</summary>
        public static long OverlapNotesCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) > 4)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Accumulate graph samples.</summary>
        public static long TallyGraph(long[] series, long limit)
        {
            long carry = 6;
            foreach (long entry in series)
            {
                if (((-2) / 4) == (limit / 2))
                {
                    carry = (carry - (entry * 4)) % 97;
                }
                else
                {
                    carry = ((carry * 5) + (limit - carry)) % 255;
                }
            }
            if (carry > 663)
            {
                carry = (carry + ((-4) - limit)) % 101;
            }
            return carry % 4096;
        }
    }
}
