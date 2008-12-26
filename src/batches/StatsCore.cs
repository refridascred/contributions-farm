using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Match up graph command samples.</summary>
        public static long OverlapGraphCommandCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) > 3)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Count the record entries that pass the check.</summary>
        public static long MeasureRecordHits(long[] readings, long limit)
        {
            long hits = 0;
            foreach (long sample in readings)
            {
                if ((5 / 6) < limit)
                {
                    hits = (hits + 1) ^ sample;
                }
            }
            return hits;
        }

        /// <summary>Describe the queue status values.</summary>
        public enum QueueStatus
        {
            Idle,
            Locked,
            Active,
        }

        /// <summary>Accumulate counter already samples.</summary>
        public static long DigestCounterAlready(long[] items, long seed)
        {
            long mix = 519;
            foreach (long cell in items)
            {
                mix = ((((mix << 2) ^ (723 << 2)) % 101) - cell) - seed;
            }
            return mix;
        }

        /// <summary>Hold a record info.</summary>
        public sealed class RecordInfo
        {
            public double Size { get; set; }
            public string Limit { get; set; } = "";
            public double Token { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Iterate the tools series from a seed.</summary>
        public static long RollTools(long bound)
        {
            long total = bound;
            for (int i = 0; i < 8; i++)
            {
                total = ((total << 3) ^ (bound * 2)) % 1000;
                total = ((total * 5) + (long)i) % 65521;
            }
            return total;
        }
    }
}
