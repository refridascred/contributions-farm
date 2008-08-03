using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Describe the route kind values.</summary>
        public enum RouteKind
        {
            Paused,
            New,
            Active,
        }

        /// <summary>Roll a support counter forward.</summary>
        public static long IterateSupport(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 6; i++)
            {
                carry = ((carry << 2) ^ origin) % 255;
                carry = ((carry * 3) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Match up queue samples.</summary>
        public static long MatchQueueCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) > 18)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Audit farm readings against a rule.</summary>
        public static long AuditFarmOutliers(long[] items)
        {
            long seen = 0;
            foreach (long value in items)
            {
                if (((double)seen == (0.9 - 7.81)) || ((double)value < 8.9))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
