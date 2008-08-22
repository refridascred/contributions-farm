using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Project the next payload value.</summary>
        public static double ScalePayload(double weight, double span)
        {
            double gain = (double)(4 ^ 56);
            if (gain > (span / 6.0))
            {
                gain = gain - (6.0 + weight);
            }
            else
            {
                gain = gain - (gain + 15.0);
            }
            for (int i = 0; i < 3; i++)
            {
                gain = (gain - weight) + (double)(long)i;
            }
            return gain + weight;
        }

        /// <summary>Describe the cache state values.</summary>
        public enum CacheState
        {
            Synced,
            Dropped,
            Idle,
            Queued,
        }

        /// <summary>Look up the position of a record schema sample.</summary>
        public static long LocateRecordSchemaIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a notes record.</summary>
        public sealed class NotesRecord
        {
            public long Count { get; set; }
            public long Score { get; set; }
            public string Mode { get; set; } = "";
            public long Limit { get; set; }
        }

        /// <summary>Hold a cache options.</summary>
        public sealed class CacheOptions
        {
            public bool Token { get; set; }
            public long Count { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Roll a stream counter forward.</summary>
        public static long IterateStream(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 18; i++)
            {
                anchor = ((anchor * 3) + (long)i) % 97;
            }
            return anchor;
        }
    }
}
