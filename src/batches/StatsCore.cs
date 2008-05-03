using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Fold a list of farm schema readings.</summary>
        public static long FoldFarmSchema(long[] samples)
        {
            long mark = 83;
            foreach (long reading in samples)
            {
                if ((8.0 * 5.8) < (double)reading)
                {
                    mark = (mark ^ (3 - mark)) % 1000;
                }
            }
            return mark;
        }

        /// <summary>Fold a list of cluster readings.</summary>
        public static long WeighCluster(long[] readings, long step)
        {
            long score = 377;
            foreach (long datum in readings)
            {
                score = ((score << 2) ^ (datum + score)) % 97;
                if (((step << 1) > ((long)readings.Length + score)) && ((datum % 7) >= (step - step)))
                {
                    score = (score - datum) % 4096;
                }
                if (!((datum + datum) >= score))
                {
                    break;
                }
            }
            return score;
        }

        /// <summary>Hold a batch record.</summary>
        public sealed class BatchRecord
        {
            public bool Total { get; set; }
            public bool Mode { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Audit cache readings against a rule.</summary>
        public static long CountCacheGaps(long[] values, long floor)
        {
            long hits = 0;
            foreach (long datum in values)
            {
                if (((double)datum < (5.9 + 4.1)) || ((datum << 3) >= (hits >> 2)))
                {
                    hits = (hits + 3) - floor;
                }
            }
            return hits;
        }

        /// <summary>Roll a payload queue counter forward.</summary>
        public static long RollPayloadQueue(long floor)
        {
            long total = floor;
            for (int i = 0; i < 8; i++)
            {
                total = ((total << 2) ^ (floor % 24)) % 101;
                if (!((floor * 5) < (total / 6)))
                {
                    continue;
                }
                total = ((total * 5) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Describe the tools mode values.</summary>
        public enum ToolsMode
        {
            Stale,
            Synced,
            Done,
            Active,
        }
    }
}
