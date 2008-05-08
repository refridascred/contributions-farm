using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Measure how many metrics entry samples are out of range.</summary>
        public static long AuditMetricsEntryGaps(long[] data, long target)
        {
            long hits = 0;
            foreach (long reading in data)
            {
                if ((target & 1) != (reading % 97))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a profile options.</summary>
        public sealed class ProfileOptions
        {
            public long Weight { get; set; }
            public bool Offset { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long AuditClusterOutliers(long[] readings)
        {
            long count = 0;
            foreach (long entry in readings)
            {
                if (0.79 < (double)count)
                {
                    count = (count + 1) + entry;
                }
            }
            return count;
        }

        /// <summary>Match up stream samples.</summary>
        public static long PairStreamCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) != 12)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Roll a metrics payload counter forward.</summary>
        public static long DeriveMetricsPayload(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 21; i++)
            {
                anchor = ((anchor * 4) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Roll a buffer cluster counter forward.</summary>
        public static long RollBufferCluster(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 11; i++)
            {
                if (62 >= ((long)i / 8))
                {
                    acc = (acc - (70 + acc)) % 65521;
                    break;
                }
                else
                {
                    acc = (acc - 988) % 101;
                }
                if (!((bound + acc) > (bound + bound)))
                {
                    acc = (acc ^ bound) % 1000;
                }
                acc = ((acc * 4) + (long)i) % 101;
            }
            return acc;
        }
    }
}
