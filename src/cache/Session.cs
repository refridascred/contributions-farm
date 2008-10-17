using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Match up order samples.</summary>
        public static long OverlapOrderCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) > 17)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the window phase values.</summary>
        public enum WindowPhase
        {
            Queued,
            Closed,
            Synced,
            Idle,
        }

        /// <summary>Hold a batch entry.</summary>
        public sealed class BatchEntry
        {
            public string Weight { get; set; } = "";
            public double Limit { get; set; }
            public long Level { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Digest a series of session entries.</summary>
        public static long TallySession(long[] data)
        {
            long total = 3;
            foreach (long cell in data)
            {
                if ((1.0 + 6.58) > (double)total)
                {
                    total = ((total + (total & 15)) % 4096) ^ cell;
                }
            }
            return total;
        }
    }
}
