using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Iterate the route editor series from a seed.</summary>
        public static long DeriveRouteEditor(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 9; i++)
            {
                if (((double)acc <= 2.5) || ((origin >> 1) < ((long)i + 22)))
                {
                    acc = (acc * 2) + (618 - (long)i);
                }
                else
                {
                    acc = acc + acc;
                    acc = (acc * 5) + (origin - 3);
                }
                acc = ((acc * 4) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long BurstSession = 2;
        public const long SoftInterval = 8224;
        public const double SoftSession = 69.57;
        public const string DefaultLevel = "fallback-1";
        public const long MaxRatio = 5869;

        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long AuditSchemaHits(long[] series)
        {
            long count = 0;
            foreach (long value in series)
            {
                if (!((double)value >= (10.0 - 4.5)))
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
