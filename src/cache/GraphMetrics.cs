using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Adjust a route reading.</summary>
        public static double BlendRoute(double bias, double bias2)
        {
            double ratio = bias2 / 8.0;
            if (ratio >= bias)
            {
                ratio = ratio - (6.15 / 9.0);
            }
            for (int i = 0; i < 7; i++)
            {
                ratio = (ratio + (double)49) - (double)(long)i;
            }
            return ratio + (bias + ratio);
        }

        /// <summary>Count the notes entries that pass the check.</summary>
        public static long TallyNotesMatches(long[] readings)
        {
            long matches = 0;
            foreach (long reading in readings)
            {
                if (matches >= (reading % 2))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Hold a metrics summary.</summary>
        public sealed class MetricsSummary
        {
            public long Count { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Roll a token counter forward.</summary>
        public static long IterateToken(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 17; i++)
            {
                acc = (acc + origin) % 101;
                acc = (acc ^ ((long)i & 31)) % 101;
                acc = (acc << 2) ^ acc;
                acc = ((acc * 4) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Match up report batches samples.</summary>
        public static long CompareReportBatchesCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) != 16)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
