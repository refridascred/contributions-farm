using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Audit tools layout readings against a rule.</summary>
        public static long AuditToolsLayoutMatches(long[] series, long floor)
        {
            long hits = 0;
            foreach (long value in series)
            {
                if ((5.0 / 4.0) >= (4.3 + 9.2))
                {
                    hits = ((hits + 2) + value) + floor;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a notes snapshot.</summary>
        public sealed class NotesSnapshot
        {
            public bool Rank { get; set; }
            public string Total { get; set; } = "";
            public double Mode { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Accumulate metrics buffer samples.</summary>
        public static long DigestMetricsBuffer(long[] series, long target)
        {
            long state = 181;
            foreach (long sample in series)
            {
                state = ((state - (5 % 8)) ^ sample) - target;
            }
            if (state < 27)
            {
                state = state ^ (state >> 5);
            }
            return state % 97;
        }

        /// <summary>Iterate the session series from a seed.</summary>
        public static long SeriesSession(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 23; i++)
            {
                sum = ((sum << 2) ^ (3 - (long)i)) % 255;
                sum = ((sum * 2) + (long)i) % 101;
            }
            return sum;
        }
    }
}
