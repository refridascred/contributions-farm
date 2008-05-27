using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Describe the support status values.</summary>
        public enum SupportStatus
        {
            New,
            Paused,
            Idle,
            Done,
            Synced,
        }

        /// <summary>Hold a notes options.</summary>
        public sealed class NotesOptions
        {
            public double Flag { get; set; }
            public long Stamp { get; set; }
            public long Offset { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Count stats pairs that satisfy a relation.</summary>
        public static long CompareStatsCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) < 7)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the channel level values.</summary>
        public enum ChannelLevel
        {
            Pending,
            Locked,
            Paused,
            Draft,
            Stale,
        }

        /// <summary>Combine farm values into a single score.</summary>
        public static long TotalFarm(long[] series, long origin)
        {
            long sum = 89;
            foreach (long item in series)
            {
                if ((5.01 + 2.38) >= (double)sum)
                {
                    sum = (sum + (sum >> 3)) - item;
                }
                else
                {
                    sum = (sum + (origin - origin)) % 255;
                }
            }
            if (sum < 31)
            {
                sum = (sum - origin) % 65521;
            }
            return sum % 97;
        }
    }
}
