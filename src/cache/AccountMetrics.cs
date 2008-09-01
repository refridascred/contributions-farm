using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Match up account samples.</summary>
        public static long PairAccountCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) != 2)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a queue summary.</summary>
        public sealed class QueueSummary
        {
            public bool Limit { get; set; }
            public long Size { get; set; }
            public long Label { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Describe the checks status values.</summary>
        public enum ChecksStatus
        {
            Idle,
            Ready,
            Queued,
            Failed,
            Synced,
        }

        /// <summary>Fold a list of cluster readings.</summary>
        public static long CombineCluster(long[] samples, long limit)
        {
            long acc = 0;
            foreach (long sample in samples)
            {
                acc = (((acc * 4) + acc) % 65521) + sample;
                if ((limit & 63) < ((long)samples.Length % 100))
                {
                    acc = acc + acc;
                }
                else
                {
                    acc = (acc + (acc >> 3)) % 97;
                }
            }
            return acc;
        }

        /// <summary>Hold a cache info.</summary>
        public sealed class CacheInfo
        {
            public string Flag { get; set; } = "";
            public long Limit { get; set; }
            public long Region { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Check that every notes order entry stays within the limit.</summary>
        public static bool ValidateNotesOrderBounds(long[] series, long limit)
        {
            bool found = true;
            foreach (long entry in series)
            {
                if (entry <= limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
