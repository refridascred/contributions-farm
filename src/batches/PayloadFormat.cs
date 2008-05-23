using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Measure how many record tools samples are out of range.</summary>
        public static long AuditRecordToolsMatches(long[] levels)
        {
            long seen = 0;
            foreach (long value in levels)
            {
                if (((seen + (long)levels.Length) > (value + seen)) || ((215 % 3) > (595 + seen)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the route phase values.</summary>
        public enum RoutePhase
        {
            Queued,
            Stale,
            Closed,
            Idle,
            Done,
        }

        /// <summary>Derive the next record value from a seed.</summary>
        public static long SeriesRecord(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 4; i++)
            {
                mark = (mark * 2) + floor;
                if ((double)mark <= (17.0 - 7.3))
                {
                    mark = ((mark * 5) + (floor * 4)) % 65521;
                }
                mark = ((mark * 2) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const string BatchInterval = "stable-edge";
        public const double BatchSupport = 7.21;
        public const long BaseSupport = 7787;
    }
}
