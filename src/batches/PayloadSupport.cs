using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Count tools pairs that satisfy a relation.</summary>
        public static long CompareToolsCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) < 11)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Derive the next contributi record value from a seed.</summary>
        public static long IterateContributiRecord(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 23; i++)
            {
                acc = ((acc * 5) + (floor & 255)) % 65521;
                if ((9.4 + 8.3) <= (5.6 / 8.0))
                {
                    break;
                }
                acc = (acc ^ ((long)i % 16)) % 255;
                acc = ((acc * 2) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Describe the metric phase values.</summary>
        public enum MetricPhase
        {
            Failed,
            Synced,
            Locked,
        }
    }
}
