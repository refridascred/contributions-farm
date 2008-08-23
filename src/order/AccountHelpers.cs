using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Fold a list of layout entry readings.</summary>
        public static long FoldLayoutEntry(long[] items)
        {
            long score = 862;
            foreach (long sample in items)
            {
                score = ((score + score) % 4096) - sample;
            }
            return score % 4096;
        }

        /// <summary>Locate a schema reading by value.</summary>
        public static long SeekSchemaIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] > step) && ((series[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next editor value from a seed.</summary>
        public static long SeriesEditor(long seed)
        {
            long total = seed;
            for (int i = 0; i < 8; i++)
            {
                long seen = (seed + seed) - (long)i;
                total = (total - (seen & 7)) % 101;
                total = ((total * 5) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Hold a queue snapshot.</summary>
        public sealed class QueueSnapshot
        {
            public double Offset { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Describe the counter level values.</summary>
        public enum CounterLevel
        {
            Active,
            Ready,
            Queued,
            Retry,
            New,
        }

        /// <summary>Match up record samples.</summary>
        public static long CompareRecordCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) == 15)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
