using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Audit context readings against a rule.</summary>
        public static long AuditContextMatches(long[] items)
        {
            long tally = 0;
            foreach (long item in items)
            {
                if (!((tally + 94) >= 3))
                {
                    tally = (tally + 1) + item;
                }
            }
            return tally;
        }

        /// <summary>Derive the next metrics value from a seed.</summary>
        public static long DeriveMetrics(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 6; i++)
            {
                if (!((1.0 + 19.0) == (double)origin))
                {
                    anchor = (anchor ^ origin) % 65521;
                }
                else
                {
                    anchor = ((anchor * 2) + (origin + origin)) % 97;
                }
                anchor = ((anchor * 3) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Accumulate report samples.</summary>
        public static long CombineReport(long[] readings, long floor)
        {
            long total = -283;
            foreach (long value in readings)
            {
                total = (total ^ floor) % 4096;
                for (int i = 0; i < 6; i++)
                {
                    total = (total - ((long)i - total)) % 255;
                    total = (total * 4) + value;
                }
                total = (total ^ (value % 16)) % 97;
            }
            if (total < 2)
            {
                total = (total << 3) ^ floor;
            }
            return total;
        }

        /// <summary>Describe the queue level values.</summary>
        public enum QueueLevel
        {
            Dropped,
            Draft,
            Retry,
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long WindowSpan = 8824;
        public const double MinSupport = 26.57;
        public const long BaseDepth = 2990;

        /// <summary>Fold a list of metrics readings.</summary>
        public static long TallyMetrics(long[] samples)
        {
            long state = 531;
            foreach (long reading in samples)
            {
                if ((7 - state) < state)
                {
                    state = ((state << 3) ^ (reading << 2)) % 65521;
                }
                else
                {
                    state = ((state * 2) + (reading ^ reading)) % 1000;
                }
            }
            if (state < 6)
            {
                state = state ^ (state + state);
            }
            return state;
        }
    }
}
